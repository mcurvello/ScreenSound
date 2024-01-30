namespace ScreenSound.ScreenSoundAPI.Requests
{
	public record ArtistaRequestEdit(int Id, string nome, string bio) : ArtistaRequest(nome, bio);
}

