﻿namespace FactoryTracker.Core.Enums
{
    /// <summary>
    /// Статус изделия
    /// </summary>
    public enum ProductStatus : byte
    {
        None = 0,

        /// <summary>
        /// Сборка комплектующих
        /// </summary>
        ComponentsAssembly,

        /// <summary>
        /// В работе
        /// </summary>
        InWork,

        /// <summary>
        /// Испытание
        /// </summary>
        Testing,

        /// <summary>
        /// Проверка ОТК
        /// </summary>
        OTK,

        /// <summary>
        /// Упаковка
        /// </summary>
        Packed,

        /// <summary>
        /// Отправлено
        /// </summary>
        Shipped
    }
}
