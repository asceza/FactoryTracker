using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Enums
{
    public enum ProductStatus : byte
    {
        Unknown,

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
