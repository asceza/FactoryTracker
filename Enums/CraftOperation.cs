using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Enums
{
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
