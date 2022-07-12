public enum RarityType
{
    Poor,
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Artifact,
    Heirloom,
}

public enum RarityColorType
{
    None,
    Black,
    Gray,
    White,
    Blue,
    Purple,
    Orange,
    Red,
    NeonBlue,
}

public static class RarityUtil
{
    public static RarityColorType RarityToColorMap(RarityType rarity)
    {
        switch(rarity) 
        {
            case RarityType.Poor:
                return RarityColorType.Black;
            case RarityType.Common:
                return RarityColorType.Gray;
     
            case RarityType.Uncommon:
                return RarityColorType.White;
       
            case RarityType.Rare:
                return RarityColorType.Blue;
          
            case RarityType.Epic:
                return RarityColorType.Purple;
          
            case RarityType.Legendary:
                return RarityColorType.Orange;
           
            case RarityType.Artifact:
                return RarityColorType.Red;
            
            case RarityType.Heirloom:
                return RarityColorType.NeonBlue;
            
            default:
                return RarityColorType.None;
         
        }
    }
}
