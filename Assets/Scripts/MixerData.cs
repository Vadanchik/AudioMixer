public static class MixerData
{
    public static class Params
    {
        public static readonly string MasterVolume = "MasterVolume";
        public static readonly string MusicVolume = "MusicVolume";
        public static readonly string EffectsVolume = "EffectsVolume";

        public static readonly int ZeroVolume = -80;
        public static readonly int MaxVolume = 0;
    }

    public enum MixerGroup
    {
        Master,
        Music,
        Effects
    }

    public static string EnumToString(MixerGroup group)
    {
        switch (group)
        {
            case MixerGroup.Master:
                return Params.MasterVolume;
            case MixerGroup.Music:
                return Params.MusicVolume;
            case MixerGroup.Effects:
                return Params.EffectsVolume;
            default:
                return null;
        }
    }
}
