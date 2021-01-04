namespace FreePBX_Utility.Utility
{
    public static class RunConfiguration
    {
        public static bool IsDebug
        {
            get
            {
                bool retVal = false;

#if DEBUG
                retVal = true;
#endif

                return retVal;
            }
        }
    }
}
