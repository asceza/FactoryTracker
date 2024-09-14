namespace FactoryTracker.Enums
{
    /// <summary>
    /// Производственная операция
    /// </summary>
    public enum CraftOperation : byte
    {
        /// <summary>
        /// Приемка комплектующих
        /// </summary>
        ComponentsReceiving,

        /// <summary>
        /// Слесарные работы
        /// </summary>
        LocksmithWork,

        /// <summary>
        /// Электромонтажные работы
        /// </summary>
        ElectricWork,

        /// <summary>
        /// Сборка заготовок
        /// </summary>
        BlanksAssembly
    }
}
