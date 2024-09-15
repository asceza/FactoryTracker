namespace FactoryTracker.Enums
{
    /// <summary>
    /// Роль пользователя
    /// </summary>
    public enum UserRole : byte
    {
        None,
        Brigadier,  // бригадир
        Master,     // мастер
        Director,   // директор
        Controller, // контроллер
        Logistician,// логист
        Worker      // рабочий
    }
}
