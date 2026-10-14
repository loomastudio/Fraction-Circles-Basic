namespace FractionCircles
{
    /// <summary>Which version of the tool this project builds.</summary>
    public static class Edition
    {
        public static bool Premium => false;
        public static bool Basic => !Premium;
    }
}
