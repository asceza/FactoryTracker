namespace FactoryTracker.DAL.Enums
{
    /// <summary>
    /// Роль пользователя
    /// </summary>
    public enum UserRole : byte
    {
        None = 0,
        Brigadier,  // бригадир
        Master,     // мастер
        Director,   // директор
        Controller, // контроллер
        Logistician,// логист
        Worker      // рабочий
    }
}
