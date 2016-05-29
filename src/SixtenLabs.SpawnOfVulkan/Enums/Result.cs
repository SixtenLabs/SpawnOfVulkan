namespace SixtenLabs.SpawnOfVulkan
{
    public enum Result : long
    {
        SUCCESS = 0,
        NotReady = 1,
        TIMEOUT = 2,
        EventSet = 3,
        EventReset = 4,
        INCOMPLETE = 5,
        ErrorOutOfHostMemory = -1,
        ErrorOutOfDeviceMemory = -2,
        ErrorInitializationFailed = -3,
        ErrorDeviceLost = -4,
        ErrorMemoryMapFailed = -5,
        ErrorLayerNotPresent = -6,
        ErrorExtensionNotPresent = -7,
        ErrorFeatureNotPresent = -8,
        ErrorIncompatibleDriver = -9,
        ErrorTooManyObjects = -10,
        ErrorFormatNotSupported = -11,
        ErrorSurfaceLostKhr = -1000000000,
        ErrorNativeWindowInUseKhr = -1000000001,
        SuboptimalKhr = 1000001003,
        ErrorOutOfDateKhr = -1000001004,
        ErrorIncompatibleDisplayKhr = -1000003001,
        ErrorValidationFailedExt = -10000011001,
        ErrorInvalidShaderNv = -10000012000,
        NvExtension1Error = -10000013000
    }
}