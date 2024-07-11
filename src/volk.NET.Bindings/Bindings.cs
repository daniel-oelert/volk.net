#nullable enable
namespace volk.NET.Bindings
{
    public static unsafe partial class Native
    {
        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_abort_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_abort_(int error_code, byte* file, int line, byte* fmt);
    }
}