
namespace dotnet_rpg.Services.ChararcterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}