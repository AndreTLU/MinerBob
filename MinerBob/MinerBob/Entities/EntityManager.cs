using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerBob.Entities
{
    class EntityManager
    {
        List<Entity> EntityList = new List<Entity>();

        private static EntityManager instance;
        private EntityManager() { }
        public static EntityManager Instance
        {
            get
            {
                if (instance == null) instance = new EntityManager();
                return instance;
            }
        }

        public void AddEntity(Entity entity)
        {
            EntityList.Add(entity);
        }

        public Entity GetEntity(int id)
        {
            return EntityList[id];
        }
    }
}
