using Boat;
using System.ComponentModel;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            // Arrange
            Boat.Boat boat = new Boat.Boat(1978, 100, "France");    // Ajouter un bateau créé en 1978, d'une capacité de 100T avec un pavillon français

            // Act
            boat.Load(new Boat.Container(1, 20));                   // Ajouter un conteneur de 20T dans le bateau
            boat.Load(new Boat.Container(2, 50));                   // Ajouter un conteneur de 50T dans le bateau (donc 70T en tout sur le bateau)

            // Assert
            Assert.IsFalse(boat.Unload(4));                         // On ne peut pas décharger le conteneur 4 car il n'est pas sur le bateau
            Assert.IsTrue(boat.Load(new Boat.Container(3, 20)));    // On peut charger le conteneur 3 (90T en tout sur le bateau)
            Assert.IsFalse(boat.Load(new Boat.Container(3, 20)));   // On ne peut pas charger le conteneur 3 car il est déjà sur le bateau
            Assert.IsFalse(boat.Load(new Boat.Container(4, 20)));   // On ne peut pas charger le conteneur 4 car pas assez de place (90 + 20 = 110 --> 110 > 100)
            Assert.IsTrue(boat.Unload(3));                          // On peut décharger le conteneur 3
            Assert.IsTrue(boat.Load(new Fridge(12, 5, 10)));        // On peut charger un conteneur frigo 4 de 10T avec une température de 12
            Assert.IsTrue(boat.Load(new Radioactive(20, 6, 10)));   // On peut charger un conteneur radioactif 5 de 10T avec une rand de 20
        }
    }
}