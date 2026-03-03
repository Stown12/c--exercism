public static class Languages
{
    public static List<string> NewList()
  {
    return new List<string>();
  }

  public static List<string> GetExistingLanguages()
  {
    return new List<string>{"C#", "Clojure", "Elm"};
  }

  public static List<string> AddLanguage(List<string> languages, string language)
  {
    if(languages.Count == 0) return new List<string>();

    List<string> languagesCopy = new List<string>(languages);
    languagesCopy.Add(language);

    return languagesCopy;
  }

  public static int CountLanguages(List<string> languages)
  {
    return languages.Count;
  }

  public static bool HasLanguage(List<string> languages, string language)
  {
    bool existsLanguage = languages.Contains(language);
    return existsLanguage;
  }

  public static List<string> ReverseList(List<string> languages)
  {
  
    List<string> languagesReverse = [.. languages];

    languagesReverse.Reverse();

    return languagesReverse;
  }

  public static bool IsExciting(List<string> languages)
  {
    if(languages.Count == 0) return false;
    if(languages.Count == 1)
    {
        return languages[0] == "C#";    
    }
      
    bool hasFirstC = languages[0] == "C#";  
    bool hasSecondC = languages[1] == "C#"; 
    bool hasTwoOrThreeLanguages = languages.Count == 2 || languages.Count == 3;

    return hasFirstC || (hasSecondC && hasTwoOrThreeLanguages);
  }
  
  public static List<string> RemoveLanguage(List<string> languages, string language)
  {
    languages.Remove(language);
    return languages;
  }

  public static bool IsUnique(List<string> languages)
  {
    HashSet<string> set = [.. languages];

    return languages.Count == set.Count;
  }
}
