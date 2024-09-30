using FactoryTracker.Enums;

namespace FactoryTracker.DAL.Models
{
    /// <summary>
    /// "Этап изделия (запись в БД)
    /// </summary>
    public class ProductStage
    {
        /// <summary>
        /// ID этапа изделия
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Изделие с которым выполняется производственная операция
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// ID исполнителя, который выполняет производственную операцию
        /// </summary>
        public int WorkerID { get; set; }

        public CraftOperation CraftOperation { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public DateTime DateTime { get; set; }
        public uint ProductionDurationInHour { get; set; }

        /// <summary>
        /// ID автора данной записи
        /// </summary>
        public int AuthorUserID { get; set; }

        public List<ProductStageComment> ProductStageComments { get; set; }

    }
}
