using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;
using Windows.UI.Xaml;

namespace UWPSoundBoard.Models
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = String.Format("/Assets/Audio/{0}/{1}.wav", category, name);
            ImageFile = String.Format("/Assets/Images/{0}/{1}.png", category, name);
        }
    }
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
    
    public class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = GetSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }
        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var allSounds = GetSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
        public static void GetSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allSounds = GetSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
        private static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }

}
