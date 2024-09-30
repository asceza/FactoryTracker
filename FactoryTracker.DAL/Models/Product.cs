using FactoryTracker.Enums;
namespace FactoryTracker.DAL.Models
{
    /// <summary>
    /// Изделие
    /// </summary>
    public class Product
    {
        /// <summary>
        /// ID изделия♥
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Тип изделия
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Номер изделия в формате 2.050/24
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Номер комплекта
        /// </summary>
        public int KitNumber { get; set; }

        /// <summary>
        /// Плановая дата выпуска изделия
        /// </summary>
        public DateTime plannedReleaseDate;

        public DateTime PlannedReleaseDate
        {
            get { return plannedReleaseDate; }
            set
            {
                if (value >= DateTime.Now)
                {
                    plannedReleaseDate = value;
                }
                return;
            }
        }

        /// <summary>
        /// Фактическая длительность производства
        /// </summary>
        public uint ActualDurationInHour { get; set; }

        /// <summary>
        /// Статус изделия
        /// </summary>
        public ProductStatus ProductStatus { get; set; }

        /// <summary>
        /// Список комментариев по изделию
        /// </summary>
        public List<ProductComment> ProductComments { get; set; }


    }
}
