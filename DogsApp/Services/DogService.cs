using DogsApp.Models;

namespace DogsApp.Services;

public class DogService
{
    private List<Dog> dogs = [
        new() { Id = 1, Name = "Golden Retriever", Age = 4 }
    ];

    public void AddDog(Dog dog)
    {   
        dogs.Add(dog);
    }

    public Dog[] GetAllDogs() => dogs.ToArray();

    public Dog? GetDogById(int id) => dogs.SingleOrDefault(d => d.Id == id); 
}
