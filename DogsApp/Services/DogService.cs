using DogsApp.Models;

namespace DogsApp.Services;

public class DogService
{
    private List<Dog> dogs = [
        new Dog { Id = 1, Name = "Buddy", Age = 3 },
            new Dog { Id = 2, Name = "Max", Age = 5 },
            new Dog { Id = 3, Name = "Bella", Age = 2 },
            new Dog { Id = 4, Name = "Charlie", Age = 4 },
            new Dog { Id = 5, Name = "Lucy", Age = 1 },
            new Dog { Id = 6, Name = "Daisy", Age = 6 },
            new Dog { Id = 7, Name = "Rocky", Age = 3 },
            new Dog { Id = 8, Name = "Luna", Age = 4 },
            new Dog { Id = 9, Name = "Cooper", Age = 2 },
            new Dog { Id = 10, Name = "Molly", Age = 5 }
    ];

    private int NextId { get => dogs.Max(o => o.Id) + 1; }

    public void AddDog(Dog dog) {
        dog.Id = NextId;
        dogs.Add(dog);
    }

    public Dog[] GetAllDogs() => dogs.ToArray();

    public Dog? GetDogById(int id) => dogs.SingleOrDefault(d => d.Id == id);
}
