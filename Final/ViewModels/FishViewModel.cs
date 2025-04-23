using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FinalProj.Models;

namespace FinalProj.ViewModels
{

    public class FishViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Grouping<string, Fish>> FishGrouped { get; }
        private ObservableCollection<Grouping<string, Fish>> _filteredFishGrouped;
        public ObservableCollection<Grouping<string, Fish>> FilteredFishGrouped
        {
            get => _filteredFishGrouped;
            set
            {
                _filteredFishGrouped = value;
                OnPropertyChanged();
            }
        }

        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                FilterFish();
            }
        }

        public FishViewModel()
        {
            var fishList = new List<Fish>
            {
                new Fish { Name = "Pufferfish", Season = "Summer", Weather = "Sun", Time = "12pm-4pm", Image = "pufferfish.png" },
                new Fish { Name = "Albacorre", Season = "Fall, Winter", Weather = "None", Time = "6am-11am, 6pm-2am", Image = "albacore.png" },
                new Fish { Name = "Anchovy", Season = "Spring, Fall", Weather = "None", Time = "Anytime", Image = "anchovy.png" },
                new Fish { Name = "Angler", Season = "Fall", Weather = "None", Time = "Anytime", Image = "angler.png" },
                new Fish { Name = "Blobfish", Season = "Winter", Weather = "None", Time = "5pm-2am", Image = "blobfish.png" },
                new Fish { Name = "Bluediscus", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "bluediscus.png" },
                new Fish { Name = "Bream", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "6pm-2am", Image = "bream.png" },
                new Fish { Name = "Bullhead", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "bullhead.png" },
                new Fish { Name = "Carp", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "carp.png" },
                new Fish { Name = "Catfish", Season = "Spring, Summer, Fall, Winter", Weather = "Rain", Time = "Anytime", Image = "catfish.png" },
                new Fish { Name = "Chub", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "chub.png" },
                new Fish { Name = "Crimsonfish", Season = "Summer", Weather = "None", Time = "Anytime", Image = "crimsonfish.png" },
                new Fish { Name = "Dorado", Season = "Summer", Weather = "None", Time = "6am-7pm", Image = "dorado.png" },
                new Fish { Name = "Eel", Season = "Spring, Fall", Weather = "Rain", Time = "4pm-2am", Image = "eel.png" },
                new Fish { Name = "Flounder", Season = "Spring, Summer", Weather = "None", Time = "6am-8pm", Image = "flounder.png" },
                new Fish { Name = "Ghostfish", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "ghostfish.png" },
                new Fish { Name = "Glacierfish", Season = "Winter", Weather = "None", Time = "6am-11pm", Image = "glacierfish.png" },
                new Fish { Name = "Glacierfish Jr.", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "glacierfishjr.png" },
                new Fish { Name = "Gobi", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "gobi.png" },
                new Fish { Name = "Halibut", Season = "Spring, Summer, Winter", Weather = "None", Time = "Anytime", Image = "halibut.png" },
                new Fish { Name = "Herring", Season = "Spring, Winter", Weather = "None", Time = "Anytime", Image = "herring.png" },
                new Fish { Name = "Ice Pip", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "icepip.png" },
                new Fish { Name = "Largemouth Bass", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "6am-7pm", Image = "largemouthbass.png" },
                new Fish { Name = "Lava Eel", Season = "Spring,Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "lavaeel.png" },
                new Fish { Name = "Legend", Season = "Spring", Weather = "Rain", Time = "6am-11pm", Image = "legend.png" },
                new Fish { Name = "Legend II", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "legendii.png" },
                new Fish { Name = "Lingcod", Season = "Winter", Weather = "None", Time = "Anytime", Image = "lingcod.png" },
                new Fish { Name = "Lionfish", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "lionfish.png" },
                new Fish { Name = "Midnight Carp", Season = "Fall, Winter", Weather = "None", Time = "10pm-2am", Image = "midnightcarp.png" },
                new Fish { Name = "Midnight Squid", Season = "Winter", Weather = "None", Time = "5pm-2am", Image = "midnightsquid.png" },
                new Fish { Name = "Ms. Angler", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "msangler.png" },
                new Fish { Name = "Mutant Carp", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "mutantcarp.png" },
                new Fish { Name = "Octopus", Season = "Summer", Weather = "None", Time = "6am-1pm", Image = "octopus.png" },
                new Fish { Name = "Perch", Season = "Winter", Weather = "None", Time = "Anytime", Image = "perch.png" },
                new Fish { Name = "Pike", Season = "Summer, Winter", Weather = "None", Time = "Anytime", Image = "pike.png" },
                new Fish { Name = "Rainbow Trout", Season = "Summer", Weather = "Sun", Time = "6am-7pm", Image = "rainbowtrout.png" },
                new Fish { Name = "Raidoactive Carp", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "radioactivecarp.png" },
                new Fish { Name = "Red Mullet", Season = "Summer, Winter", Weather = "None", Time = "6am-7pm", Image = "redmullet.png" },
                new Fish { Name = "Red Snapper", Season = "Summer, Fall", Weather = "Rain", Time = "6am-7pm", Image = "redsnapper.png" },
                new Fish { Name = "Salmon", Season = "Fall, Winter", Weather = "None", Time = "6am-7pm", Image = "salmon.png" },
                new Fish { Name = "Sandfish", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "6am-8pm", Image = "sandfish.png" },
                new Fish { Name = "Sardine", Season = "Spring, Fall, Winter", Weather = "None", Time = "6am-7pm", Image = "sardine.png" },
                new Fish { Name = "Scorpion Carp", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "6am-8pm", Image = "scorpioncarp.png" },
                new Fish { Name = "Sea Cucumber", Season = "Fall, Winter", Weather = "None", Time = "6am-7pm", Image = "seacucumber.png" },
                new Fish { Name = "Shad", Season = "Spring, Summer, Fall", Weather = "Rain", Time = "9am-2am", Image = "shad.png" },
                new Fish { Name = "Slimejack", Season = "Spring, Summer, Fall", Weather = "None", Time = "Anytime", Image = "slimejack.png" },
                new Fish { Name = "Smallmouth Bass", Season = "Spring, Fall", Weather = "None", Time = "Anytime", Image = "smallmouthbass.png" },
                new Fish { Name = "Spook Fish", Season = "Winter", Weather = "None", Time = "5pm-2am", Image = "spookfish.png" },
                new Fish { Name = "Squid", Season = "Winter", Weather = "None", Time = "6pm-2am", Image = "squid.png" },
                new Fish { Name = "Stingray", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "stingray.png" },
                new Fish { Name = "Stonefish", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "stonefish.png" },
                new Fish { Name = "Sturgeon", Season = "Summer, Winter", Weather = "None", Time = "6am-7pm", Image = "sturgeon.png" },
                new Fish { Name = "Sunfish", Season = "Spring, Summer", Weather = "Sun", Time = "6am-7pm", Image = "sunfish.png" },
                new Fish { Name = "Super Cucumber", Season = "Summer, Fall, Winter", Weather = "None", Time = "6pm-2am", Image = "supercucumber.png" },
                new Fish { Name = "Tiger Trout", Season = "Fall, Winter", Weather = "None", Time = "6am-7pm", Image = "tigertrout.png" },
                new Fish { Name = "Tilapia", Season = "Summer, Fall", Weather = "None", Time = "6am-2pm", Image = "tilapia.png" },
                new Fish { Name = "Tuna", Season = "Summer, Winter", Weather = "None", Time = "6am-2pm", Image = "tuna.png" },
                new Fish { Name = "Void Salmon", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "voidsalmon.png" },
                new Fish { Name = "Walleye", Season = "Fall", Weather = "Rain", Time = "12pm-2am", Image = "walleye.png" },
                new Fish { Name = "Woodskip", Season = "Spring, Summer, Fall, Winter", Weather = "None", Time = "Anytime", Image = "woodskip.png" }
                //Add any new fish here
                };

            var sortedFishList = fishList.OrderBy(f => f.Name).ToList();

            FishGrouped = new ObservableCollection<Grouping<string, Fish>>
            {
                new Grouping<string, Fish>("All Fish", sortedFishList)
            };

            // Initialize FilteredFishGrouped with all fish
            FilteredFishGrouped = new ObservableCollection<Grouping<string, Fish>>(FishGrouped);
        }

        private void FilterFish()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                // If search text is empty, show all fish
                FilteredFishGrouped = new ObservableCollection<Grouping<string, Fish>>(FishGrouped);
            }
            else
            {
                // Filter fish based on search text
                var filteredFish = FishGrouped
                    .SelectMany(g => g)
                    .Where(f => f.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                                f.Season.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                                f.Time.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                                f.Weather.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(f => f.Name)
                    .ToList();

                FilteredFishGrouped = new ObservableCollection<Grouping<string, Fish>>
                {
                    new Grouping<string, Fish>("Some Fish", filteredFish)
                };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; }

            public Grouping(K key, IEnumerable<T> items) : base(items)
            {
                Key = key;
            }
        }
    }
}


