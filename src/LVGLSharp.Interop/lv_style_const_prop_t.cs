namespace LVGLSharp.Interop
{
    public partial struct lv_style_const_prop_t
    {
        [NativeTypeName("lv_style_prop_t")]
        public c_uint8 prop;

        public lv_style_value_t value;
    }
}
