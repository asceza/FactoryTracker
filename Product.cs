using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker
{
    /// <summary>
    /// Изделие
    /// </summary>
    public class Product
    {
        public uint ID { get; set; }
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Номер изделия в формате 2.050/24
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Номер комплекта
        /// </summary>
        public uint KitNumber { get; set; }


        public DateTime plannedReleaseDate;

        /// <summary>
        /// Плановая дата выпуска изделия
        /// </summary>
        public DateTime PlannedReleaseDate
        {
            get { return plannedReleaseDate; }
            set
            {
                if (value >= DateTime.Now)
                {
                    plannedReleaseDate = value;
                }
                return; // TODO сообщение пользователю
            }
        }

        /// <summary>
        /// Фактическая длительность производства
        /// ?нужно вводить это свойсво или счить по данным из БД?
        /// </summary>
        public uint ActualDurationInHour { get; set; }

        public ProductStatus ProductStatus { get; set; }

        public List<Comment> Comments { get; set; }

        public Product(uint id,
                       ProductType productType,
                       string number, uint kitNumber,
                       DateTime plannedReleaseDate,
                       ProductStatus productStatus,
                       uint actualDurationInHour = 0)
        {
            ID = id;
            ProductType = productType;
            Number = number;
            KitNumber = kitNumber;
            PlannedReleaseDate = plannedReleaseDate;
            ProductStatus = productStatus;
            ActualDurationInHour = actualDurationInHour;
            Comments = new List<Comment>();
        }

    }
}
