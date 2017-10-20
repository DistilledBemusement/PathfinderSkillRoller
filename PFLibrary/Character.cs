using System;
using System.Collections.Generic;
using System.Text;

namespace PFLibrary {
        public class Character {
                private int ID { get; set; }
                private string Name;
                private List<Skill> Skills;

                public int returnID() {
                        return ID;
                }

                public string returnName() {
                        return Name;
                }

                public Character(string _name) {
                        Name = _name;
                }

                public void SkillAdd(string _name, int _score) {
                        Skill newSkill = new Skill(_name, _score);
                        Skills.Add(newSkill);
                }

                public void SkillDelete(int _ID) {
                        foreach (Skill item in Skills) {
                                if (item.returnID() == _ID) {
                                        Skills.Remove(item);
                                }
                        }
                }

                public Skill SkillRetrieve(int _ID) {
                        foreach (Skill item in Skills) {
                                if (item.returnID() == _ID) {
                                        return item;
                                }
                        }
                        return null;
                }
        }
}
