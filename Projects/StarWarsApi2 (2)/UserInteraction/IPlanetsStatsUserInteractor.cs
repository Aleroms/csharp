﻿public interface IPlanetsStatsUserInteractor
{
    void Show(IEnumerable<Planet> planets);
    string? ChooseStatisticsToBeShown(
        IEnumerable<string> propertiesThatCanBeChosen);
    void ShowMessage(string msg);
}
