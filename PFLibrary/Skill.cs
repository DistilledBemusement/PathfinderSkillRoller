using System;
using System.Collections.Generic;
using System.Text;

namespace PFLibrary {
        public class Skill {
                private int ID { get; set; }
                private string Name;
                private int Score;

                public Skill(string _name, int _score) {
                        Name = _name;
                        Score = _score;
                }

                public string returnName() {
                        return Name;
                }

                public int returnID() {
                        return ID;
                }

                public int returnScore() {
                        return Score;
                }
        }
}
