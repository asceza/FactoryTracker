using FactoryTracker.Enums;

namespace FactoryTracker.Models
{
    /// <summary>
    /// "Этап производства (запись в БД)
    /// </summary>
    public class ProductStage
    {
        /// <summary>
        /// ID этапа изделия
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// Изделие с которым выполняется производственная операция
        /// </summary>
        public uint ProductID { get; set; }

        /// <summary>
        /// ID исполнителя, который выполняет производственную операцию
        /// </summary>
        public uint WorkerID { get; set; }

        public CraftOperation CraftOperation { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public DateTime DateTime { get; set; }
        public uint ProductionDurationInHour { get; set; }

        /// <summary>
        /// ID автора данной записи
        /// </summary>
        public uint AutorUserID { get; set; }

    }
}
