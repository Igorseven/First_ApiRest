namespace SaveCars.API.Util
{
    public static class MethodExtention
    {
        public static bool IsMethodGet(dynamic context) => context.HttpContext.Request.Method == "GET";
    }
}
