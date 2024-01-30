using System.ComponentModel.DataAnnotations;

namespace ScreenSound.ScreenSoundAPI.Requests
{
    public record MusicaRequest([Required] string nome, [Required] int ArtistaId, int anoLancamento);
}
