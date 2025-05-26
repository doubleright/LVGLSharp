namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_builtin_font_src_t
    {
        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* font_p;

        [NativeTypeName("uint32_t")]
        public c_uint32 size;
    }
}
