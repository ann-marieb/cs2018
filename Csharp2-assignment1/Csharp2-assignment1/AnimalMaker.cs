/// AnimalMaker.cs
/// Ann-Marie Bergström  ai2436 2018-02-14

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment1
{
    /// <summary>
    /// Handles animal category and species specific information to be displayed in MainForm. 
    /// When new animal categories and species are introduced, changes have to be made.
    /// </summary>
    class AnimalMaker
    {
        private static int animalID = 100; //unique id for each animal

        #region Info to be displayed in MainForm based on input.

        /// <summary>
        /// Create Species strings
        /// </summary>
        /// <returns>returns Species list </returns>
        internal static List<string> GetSpeciesNames(string animalCategory)
        {
            List<string> speciesList = new List<string>();

            switch (animalCategory)
            {
                case "birds":
                    foreach (string species in Enum.GetNames(typeof(BirdCategory)))
                    {
                        speciesList.Add(species);
                    }
                    break;
                case "mammals":
                    foreach (string species in Enum.GetNames(typeof(MammalCategory)))
                    {
                        speciesList.Add(species);
                    }
                    break;
                case "all":
                    foreach (string species in Enum.GetNames(typeof(MammalCategory)))
                    {
                        speciesList.Add(species);
                    }
                    foreach (string species in Enum.GetNames(typeof(BirdCategory)))
                    {
                        speciesList.Add(species);
                    }
                    break;

                default:
                    break;
            }
            return speciesList;
        }

        /// <summary>
        /// return string to be used as label for animal category specific info based on selected animal category.
        /// </summary>
        /// <param name="animalCategory"></param>
        /// <returns>label text</returns>
        internal static string LabelText(string text)
        {
            string labelText;

            switch (text)
            {
                case "birds":
                    labelText = "Wing span (cm)";
                    break;
                case "mammals":
                    labelText = "Number of teeth";
                    break;

                case "falcon":
                    labelText = "Flying speed (km/h)";
                    break;
                case "parrot":
                    labelText = "Colour";
                    break;
                case "cat":
                    labelText = "Colour";
                    break;
                case "dog":
                    labelText = "Breed";
                    break;
                default:
                    labelText = "";
                    break;
            }
            return labelText;
        }

        /// <summary>
        /// return string to be used as groupbox name based on selected animal category.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>groupbox name</returns>
        internal static string GroupBoxName(string text)
        {
            string groupboxName;

            switch (text)
            {
                case "falcon":
                case "parrot":
                    groupboxName = "birds";
                    break;
                case "cat":
                case "dog":
                    groupboxName = "mammals";
                    break;
                default:
                    groupboxName = "";
                    break;
            }
            return groupboxName;
        }

        /// <summary>
        ///if Animal Category "all" is selected, species selection generates groupbox name and 
        ///label for animal category specific info.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>label text</returns>
        internal static string AnimalCategoryInfoWhenAnimalSelected(string text)
        {
            string labelText;

            switch (text)
            {
                case "falcon":
                case "parrot":
                    labelText = "Wing span (cm)";
                    break;
                case "cat":
                case "dog":
                    labelText = "Number of teeth";
                    break;

                default:
                    labelText = "";
                    break;
            }
            return labelText;
        }
        
        #endregion

        /// <summary>
        /// Check if input fields are valid for creation of animal.
        /// </summary>
        /// <returns>Error text</returns>
        internal static string ValidateInput(string name, string agetext, int index, string species, string text1, string text2)
        {
            string errorText = "";
            int maxAge = 0;
            if (string.IsNullOrEmpty(name)) errorText = " Please give the " + species + "'s name.";
            if (index == -1) errorText = errorText + " Please select gender.";
            bool isAgeInteger = int.TryParse(agetext, out int ageInt);

            switch (species)
            {
                case "cat":
                    maxAge = 25;
                    bool isNoOfTeethInteger2 = int.TryParse(text1, out int noOfTeethInt2);
                    if (!isNoOfTeethInteger2 || noOfTeethInt2 < 0 || noOfTeethInt2 > 35) errorText = errorText + " No of teeth not valid.";
                    if (string.IsNullOrEmpty(text2)) errorText = errorText + " Please give the cat's colour.";
                    break;
                case "dog":
                    maxAge = 35;
                    bool isNoOfTeethInteger = int.TryParse(text1, out int noOfTeethInt);
                    if (!isNoOfTeethInteger || noOfTeethInt< 0 || noOfTeethInt > 50) errorText = errorText + " No of teeth not valid.";
                    if (string.IsNullOrEmpty(text2)) errorText = errorText + " Please give the dog's breed.";
                    break;
                case "falcon":
                    maxAge = 30;
                    bool isWingSpanInteger = int.TryParse(text1, out int wingSpanInt);
                    if (!isWingSpanInteger || wingSpanInt < 0 || wingSpanInt > 180) errorText = errorText + " Wing span not valid.";
                    bool isFlyingSpeedInteger = int.TryParse(text2, out int flyingSpeedInt);
                    if (!isFlyingSpeedInteger || flyingSpeedInt < 0 || flyingSpeedInt > 350) errorText = errorText + " Falcon's flying speed not valid.";
                    break;
                case "parrot":
                    maxAge = 110;
                    bool isWingSpanInteger2 = int.TryParse(text1, out int wingSpanInt2);
                    if (!isWingSpanInteger2 || wingSpanInt2 < 0 || wingSpanInt2 > 120) errorText = errorText + " Wing span not valid.";
                    if (string.IsNullOrEmpty(text2)) errorText = errorText + " Please give the parrot's colour.";
                    break;
            }
            if (!isAgeInteger || ageInt < 0 || ageInt > maxAge) errorText = errorText + " Age not valid.";

            return errorText;
        }

        /// <summary>
        /// Create animal ID
        /// </summary>
        /// <returns>animal ID</returns>
        private static int NewId()
        {
            return animalID++;
        }

        /// <summary>
        /// Create animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ageInt"></param>
        /// <param name="gender"></param>
        /// <param name="species"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns>animal</returns>
        internal static Animal MakeAnimal(string name, int ageInt, string gender, string species, string text1, string text2)
        {
            Animal animal; //declare animal

            switch (species)
            {
                case "dog":
                    {
                      animal = new Dog(NewId(), name, ageInt, gender, text1, text2);
                    }
                    break;
                case "cat":
                    {
                        animal = new Cat(NewId(), name, ageInt, gender, text1, text2);
                    }
                    break;
                case "parrot":
                    {
                        animal = new Parrot(NewId(), name, ageInt, gender, text1, text2);
                    }
                    break;
                case "falcon":
                    {
                        animal = new Falcon(NewId(), name, ageInt, gender, text1, text2);
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }
            return animal;
        }

    }
}
