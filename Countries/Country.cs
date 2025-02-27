﻿namespace Countries;

public interface Country
{
  private static Country[] CountryList = { new Germany(), new Netherlands() };
  public static void CheckForAllCountries(int age)
  {
    foreach (Country country in CountryList)
    {
      Console.WriteLine($"Country: {country.GetName()}");
      country.CheckLegality(age);
    }
  }

  protected String GetName();

  protected void CheckPublicLegality(uint age);

}
