using Newtonsoft.Json;
using Otus_HomeWork9;
using Xunit;

namespace Tests
{
    public class Clone
    {
        [Fact]
        public void CatClone()
        {
            var cat = new Cat("Муся", true, 10, true, true, 5);
            var catClone = cat.Clone();
            
            var catJson= JsonConvert.SerializeObject(cat);
            var catCloneJson = JsonConvert.SerializeObject(catClone);

            Assert.NotNull(catClone);
            Assert.False(cat.Equals(catClone));
            Assert.Equal(catJson, catCloneJson);
        }
        [Fact]
        public void EelClone()
        {
            var obj = new Eel(true, 3, false, 15, true, false, 1);
            var objClone = obj.Clone();

            var objJson = JsonConvert.SerializeObject(obj);
            var objCloneJson = JsonConvert.SerializeObject(objClone);

            Assert.NotNull(objClone);
            Assert.False(obj.Equals(objClone));
            Assert.Equal(objJson, objCloneJson);
        }
        [Fact]
        public void ParrotClone()
        {
            var obj = new Parrot("Кеша", true, 0.04, false, true, 5);
            var objClone = obj.Clone();

            var objJson = JsonConvert.SerializeObject(obj);
            var objCloneJson = JsonConvert.SerializeObject(objClone);

            Assert.NotNull(objClone);
            Assert.False(obj.Equals(objClone));
            Assert.Equal(objJson, objCloneJson);
        }
        [Fact]
        public void RoosterClone()
        {
            var obj = new Rooster(true, false, 3, false, true, 3);
            var objClone = obj.Clone();

            var objJson = JsonConvert.SerializeObject(obj);
            var objCloneJson = JsonConvert.SerializeObject(objClone);

            Assert.NotNull(objClone);
            Assert.False(obj.Equals(objClone));
            Assert.Equal(objJson, objCloneJson);
        }
    }
}