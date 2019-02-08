public class PlayerStats{
    public static int Life { get; set; } = 5;
    public static int MaxLife { get; set; } = 5;


    public static void ResetStats(){
        Life = MaxLife = 5;
    }
}
