using System;
using System.Collections.Generic;

namespace TrickyCsharp
{
    class Covariance
    {
        public class Entity
        {            
        }

        public class User : Entity
        {
        }

        //Covariance:
        public interface IEntityRepository<out TEntity> where TEntity : Entity
        {
            TEntity GetById(Guid id);

        }

        public class UserRepository : IEntityRepository<User>
        {
            public User GetById(Guid id)
            {
                return new User();
            }
        }

        //Contravariance:
        public interface IEqualityComparer<in TEntity> where TEntity : Entity
        {
            bool Equals(TEntity left, TEntity right);
        }

        public class EntityEqualityComparer : IEqualityComparer<Entity>
        {
            public bool Equals(Entity left, Entity right)
            {
                throw new NotImplementedException();
            }
        }

        //Invariance:
        public void Test()
        {
            //compilation error:
            //List<object> list = new List<int>(); //type is not invariant
        }
    }
}
