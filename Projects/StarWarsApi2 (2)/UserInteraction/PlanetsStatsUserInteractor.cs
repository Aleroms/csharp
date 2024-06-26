﻿public class PlanetsStatsUserInteractor : IPlanetsStatsUserInteractor
{
    private readonly IUserInteractor _userInteractor;

    public PlanetsStatsUserInteractor(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public string? ChooseStatisticsToBeShown(IEnumerable<string> propertiesThatCanBeChosen)
    {
        _userInteractor.ShowMessage(Environment.NewLine);
        _userInteractor.ShowMessage(
            "The statistics of which property would you " +
            "like to see?");
        _userInteractor.ShowMessage(string.Join(Environment.NewLine,
            propertiesThatCanBeChosen));

        return _userInteractor.ReadFromUser();
    }

    public void Show(IEnumerable<Planet> planets)
    {
        throw new NotImplementedException();
    }

    public void ShowMessage(string msg)
    {
        throw new NotImplementedException();
    }

    
}
public static class TablePrinter
{
    public static void Print<T>(IEnumerable<T> planets)
    {
        var properties = typeof(T).GetProperties();
    }
}
