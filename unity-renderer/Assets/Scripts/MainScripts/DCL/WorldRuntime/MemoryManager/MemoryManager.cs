using System.Collections;
using System.Collections.Generic;
using DCL.Configuration;
using DCL.SettingsCommon.SettingsControllers.BaseControllers;
using DCL.SettingsCommon.SettingsControllers.SpecificControllers;
using UnityEngine;
using UnityEngine.Profiling;

namespace DCL
{
    public class MemoryManager : IMemoryManager
    {
        private const long MAX_USED_MEMORY = 2020 * 1024 * 1024; // 1.6GB
        private const long MED_USED_MEMORY = 1800 * 1024 * 1024;
        private const long LOW_USED_MEMORY = 1500 * 1024 * 1024;
        private const float TIME_FOR_NEW_MEMORY_CHECK = 60.0f;
        private ScenesLoadRadiusControlController sceneLoadRadiusSettingController;

        private Coroutine autoCleanupCoroutine;

        private long memoryThresholdForCleanup = 0;
        private float cleanupInterval;

        public event System.Action OnCriticalMemory;

        public MemoryManager (long memoryThresholdForCleanup, float cleanupInterval)
        {
            this.memoryThresholdForCleanup = memoryThresholdForCleanup;
            this.cleanupInterval = cleanupInterval;
            autoCleanupCoroutine = CoroutineStarter.Start(AutoCleanup());
        }

        public MemoryManager ()
        {
            this.memoryThresholdForCleanup = MAX_USED_MEMORY;
            this.cleanupInterval = TIME_FOR_NEW_MEMORY_CHECK;
            sceneLoadRadiusSettingController = ScriptableObject.FindObjectOfType<ScenesLoadRadiusControlController>();
            if (sceneLoadRadiusSettingController == null)
            {
                sceneLoadRadiusSettingController = ScriptableObject.CreateInstance<ScenesLoadRadiusControlController>();    
                sceneLoadRadiusSettingController.Initialize();
            }
            autoCleanupCoroutine = CoroutineStarter.Start(AutoCleanup());
            CoroutineStarter.Start(FastMemCheck());
        }

        public void Dispose()
        {
            if (autoCleanupCoroutine != null)
                CoroutineStarter.Stop(autoCleanupCoroutine);

            autoCleanupCoroutine = null;
        }

        public void Initialize()
        {
        }

        bool NeedsMemoryCleanup()
        {
            long usedMemory = Profiler.GetTotalAllocatedMemoryLong() + Profiler.GetMonoUsedSizeLong() + Profiler.GetAllocatedMemoryForGraphicsDriver();
            return usedMemory >= this.memoryThresholdForCleanup;
        }

        IEnumerator AutoCleanup()
        {
            while (true)
            {
                if (NeedsMemoryCleanup())
                {
                    OnCriticalMemory?.Invoke();
                    yield return CleanPoolManager();
                    Resources.UnloadUnusedAssets();
                }

                yield return new WaitForSecondsRealtime(this.cleanupInterval);
            }
        }

        IEnumerator FastMemCheck()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            while(true){
                long usedMemory = Profiler.GetTotalAllocatedMemoryLong() + Profiler.GetMonoUsedSizeLong() + Profiler.GetAllocatedMemoryForGraphicsDriver();

                if (usedMemory < LOW_USED_MEMORY)
                {
                    DataStore.i.textureConfig.gltfMaxSize.Set(TextureCompressionSettings.GLTF_TEX_MAX_SIZE_WEB);
                    DataStore.i.textureConfig.generalMaxSize.Set(TextureCompressionSettings.GENERAL_TEX_MAX_SIZE_WEB);
                    QualitySettings.masterTextureLimit = 0;
                    sceneLoadRadiusSettingController.UpdateSetting(4.0f);
                }
                else if ( usedMemory < MED_USED_MEMORY)
                {
                    DataStore.i.textureConfig.gltfMaxSize.Set(TextureCompressionSettings.GLTF_TEX_MAX_SIZE_WEB);
                    DataStore.i.textureConfig.generalMaxSize.Set(TextureCompressionSettings.GENERAL_TEX_MAX_SIZE_WEB);
                    QualitySettings.masterTextureLimit = 1;
                    sceneLoadRadiusSettingController.UpdateSetting(3.0f);
                }
                else if (usedMemory < MAX_USED_MEMORY)
                {
                    DataStore.i.textureConfig.gltfMaxSize.Set(TextureCompressionSettings.GLTF_TEX_MAX_SIZE_WEB/2);
                    DataStore.i.textureConfig.generalMaxSize.Set(TextureCompressionSettings.GENERAL_TEX_MAX_SIZE_WEB/2);
                    QualitySettings.masterTextureLimit = 2;
                    sceneLoadRadiusSettingController.UpdateSetting(2.0f);
                }
                else
                {
                    DataStore.i.textureConfig.gltfMaxSize.Set(TextureCompressionSettings.GLTF_TEX_MAX_SIZE_WEB/8);
                    DataStore.i.textureConfig.generalMaxSize.Set(TextureCompressionSettings.GENERAL_TEX_MAX_SIZE_WEB/8);
                    QualitySettings.masterTextureLimit = 4;
                    sceneLoadRadiusSettingController.UpdateSetting(1.0f);
                }
                Debug.Log($"Memory: {usedMemory/1000000}Mb, gltf {DataStore.i.textureConfig.gltfMaxSize.Get()}, general {DataStore.i.textureConfig.generalMaxSize.Get()}, textLevel {QualitySettings.masterTextureLimit}");

                    yield return  new WaitForSeconds(5);
            }
#endif
            yield return null;
        }

        public IEnumerator CleanPoolManager(bool forceCleanup = false, bool immediate = false)
        {
            bool unusedOnly = true;
            bool nonPersistentOnly = true;

            if ( forceCleanup )
            {
                unusedOnly = false;
                nonPersistentOnly = false;
            }

            if ( immediate )
            {
                PoolManager.i.Cleanup(unusedOnly, nonPersistentOnly);
            }
            else
            {
                yield return PoolManager.i.CleanupAsync(unusedOnly, nonPersistentOnly, false);
            }
        }
    }
}