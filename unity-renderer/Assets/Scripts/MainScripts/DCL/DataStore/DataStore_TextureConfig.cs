namespace DCL
{
    public class DataStore_TextureConfig
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        public readonly BaseVariable<int> generalMaxSize = new BaseVariable<int>(2048);
        public readonly BaseVariable<int> gltfMaxSize = new BaseVariable<int>(512);   
#else
        public readonly BaseVariable<int> generalMaxSize = new BaseVariable<int>(2048*2);
        public readonly BaseVariable<int> gltfMaxSize = new BaseVariable<int>(1024*2);
        #endif
        public readonly BaseVariable<bool> runCompression = new BaseVariable<bool>(false);
    }
}