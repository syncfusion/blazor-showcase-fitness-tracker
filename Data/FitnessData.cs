namespace FitnessTracker.Data
{
    public class ProfileInfo
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Location { get; set; } = string.Empty;
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Goal { get; set; }
        public string Email { get; set; } = string.Empty;
        public string WeightMes { get; set; } = string.Empty;
        public string GoalMes { get; set; } = string.Empty;
        public string HeightMes { get; set; } = string.Empty;
    }

    public class Activity
    {
        public string? Name { get; set; }
        public string? ActivityType { get; set; }
        public string? Duration { get; set; }
        public int Count { get; set; }
        public string? Amount { get; set; }
        public string? Distance { get; set; }
        public string? Percentage { get; set; }
        public string? Time { get; set; }
    }

    public class ChartData
    {
        public DateTime X { get; set; }
        public double Y { get; set; }
    }
    public class GridListData
    {
        public string? Workout { get; set; }
        public double? Distance { get; set; }
        public double Duration { get; set; }
        public DateTime Date { get; set; }
        public double Completion { get; set; }
    }

    public class PieChartData
    {
        public string X { get; set; } = string.Empty;
        public double Y { get; set; }
        public string Fill { get; set; } = string.Empty;
    }

    public class MenuItems
    {
        public string Item { get; set; } = string.Empty;
        public int Cal { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Proteins { get; set; }
        public double Sodium { get; set; }
        public double Iron { get; set; }
        public double Calcium { get; set; }
        public bool IsAdded { get; set; }
        public int? Quantity { get; set; }
    }

    public class ActivitiesData
    {
        public int HeartRate { get; set; } = 80;
        public int Steps { get; set; } = 1240;
        public int SleepInMinutes { get; set; } = 350;
        public List<GridListData> GridData { get; set; } = new List<GridListData>();
        public List<ChartData> ChartData { get; set; } = new List<ChartData>();
        public List<ChartData> ChartDietData { get; set; } = new List<ChartData>();
        public int MorningWalk { get; set; }
        public string ChartDropDownValue { get; set; } = "Weekly";
        public ChartPeriodData ActivityChartMonthData { get; set; } = new ChartPeriodData();
        public ChartPeriodData ActivityChartWeekData { get; set; } = new ChartPeriodData();
    }

    public class ChartPeriodData
    {
        public List<ChartData>? Diet { get; set; }
        public List<ChartData>? Workout { get; set; }
    }

    public class DietData
    {
        public List<MenuItems> CurrentBreakFastMenu { get; set; } = new List<MenuItems>();
        public List<MenuItems> CurrentSnack1Menu { get; set; } = new List<MenuItems>();
        public List<MenuItems> CurrentLunchMenu { get; set; } = new List<MenuItems>();
        public List<MenuItems> CurrentSnack2Menu { get; set; } = new List<MenuItems>();
        public List<MenuItems> CurrentDinnerMenu { get; set; } = new List<MenuItems>();
        public int CurrentBreakFastCalories { get; set; }
        public string CurrentBreakFastMenuText { get; set; } = string.Empty;
        public bool IsBreakFastMenuAdded { get; set; }
        public int CurrentSnack1Calories { get; set; }
        public string CurrentSnack1MenuText { get; set; } = string.Empty;
        public bool IsSnack1MenuAdded { get; set; }
        public int CurrentLunchCalories { get; set; }
        public bool IsLunchMenuAdded { get; set; }
        public string CurrentLunchMenuText { get; set; } = string.Empty;
        public int CurrentSnack2Calories { get; set; }
        public bool IsSnack2MenuAdded { get; set; }
        public string CurrentSnack2MenuText { get; set; } = string.Empty;
        public int CurrentDinnerCalories { get; set; }
        public bool IsDinnerMenuAdded { get; set; }
        public string CurrentDinnerMenuText { get; set; } = string.Empty;
        public int ConsumedCalories { get; set; }
        public int BurnedCalories { get; set; }
        public int BreakfastWaterTaken { get; set; }
        public int LunchWaterTaken { get; set; }
        public double CurrentTotalProteins { get; set; }
        public double CurrentTotalFat { get; set; }
        public double CurrentTotalCarbs { get; set; }
        public double CurrentTotalCalcium { get; set; }
        public double CurrentTotalIron { get; set; }
        public double CurrentTotalSodium { get; set; }
        public DateTime CurrentBreakFastTime { get; set; }
        public DateTime CurrentSnack1Time { get; set; }
        public DateTime CurrentLunchTime { get; set; }
        public DateTime CurrentSnack2Time { get; set; }
        public DateTime CurrentDinnerTime { get; set; }
    }

    public class FastingData
    {
        public int ConsumedWaterCount { get; set; } = 4;
        public int ConsumedWaterAmount { get; set; } = 600;
        public int ExpectedWaterAmount { get; set; } = 2400;
        public DateTime CountStartDate { get; set; }
        public DateTime CountDownDate { get; set; }
        public bool IsFastingEnded { get; set; }
        public List<ChartData> WeightChartData { get; set; } = new List<ChartData>();
    }
}