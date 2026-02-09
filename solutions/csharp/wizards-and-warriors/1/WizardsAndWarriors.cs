abstract class Character
{
  protected string _characterType = string.Empty;
  
  
  protected Character(string characterType)
  {
    this._characterType = characterType;
  }
  
  // Método abstracto que obliga a las subclases a implementarlo
  public abstract int DamagePoints(Character target);

  public virtual bool Vulnerable()
  {
    return false;
    
  }
  public override string ToString()
  {
    return $"Character is a {this._characterType}";
  }
  
}

class Warrior: Character
{

  //* base se utiliza para llamar al constructor de la clase base (superclase) desde una clase derivada (subclase). Esto es especialmente útil cuando la clase base tiene un constructor que requiere parámetros y deseas asegurarte de que se inicialice correctamente al crear una instancia de la clase derivada.
  public Warrior() : base("Warrior")
  {
    
  }
  public override int DamagePoints(Character target)
  {
    return target.Vulnerable() ? 10 : 6;
  }
}

class Wizard: Character
{
  private bool speel = false;
  public Wizard() : base("Wizard")
  {
    
  }

  public override int DamagePoints(Character target)
  {
    
    return speel ? 12 : 3;
  }

  public void PrepareSpell()
  {
    this.speel = true;
  }

    public override bool Vulnerable()
    {
      return !speel;

    }
  
  
}