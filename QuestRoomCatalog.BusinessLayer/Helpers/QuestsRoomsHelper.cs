using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public class QuestsRoomsHelper : ICrud<QuestsRoomsBO>
    {
        UnitOfWork Db { get; set; }
        public QuestsRoomsHelper(UnitOfWork uow)
        {
            Db = uow;
        }
        public void Create(QuestsRoomsBO Bo)
        {
            if (Bo.Id == 0)
            {
                QuestsRooms questRooms = AutoMapper<QuestsRoomsBO, QuestsRooms>.Map(Bo);
                Db.QuestsRoomsUowRepository.Add(questRooms);
                Db.Save();
            }
        }
    }
}
