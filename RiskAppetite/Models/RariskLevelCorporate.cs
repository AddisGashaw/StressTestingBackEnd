using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RariskLevelCorporate
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public int? RiskLevelId { get; set; }

    public string? OneBorrowerAgainstCapital { get; set; }

    public string? SingleBorrowerAgainstCapital { get; set; }

    public string? OneRelatedPartyAgainstCapital { get; set; }

    public string? AllRelatedPartiesAgainstCapital { get; set; }

    public string? Top10PvtBorrowersAgainstTotalPvtOsb { get; set; }

    public string? Top100PvtBorrowersAgainstTotalPvtOsb { get; set; }

    public string? Top200PvtBorrowersAgainstTotalPvtOsb { get; set; }

    public string? ShareOfAgricultureFromTotalOsb { get; set; }

    public string? ShareOfBuildingAndConFromTotalOsb { get; set; }

    public string? ShareOfDtsFromTotalOsb { get; set; }

    public string? ShareOfManufacturingFromTotalOsb { get; set; }

    public string? ShareOfIntTradeFromTotalOsb { get; set; }

    public string? ShareOfFinancialInstFromTotalOsb { get; set; }

    public string? ShareOfOthersFromTotalOsb { get; set; }

    public string? ShareOfConsumerLoanFromTotalOsb { get; set; }

    public string? ShareOfAnimalHusbandryFromAgriTotalOsb { get; set; }

    public string? ShareOfPermanentCropsFromAgriTotalOsb { get; set; }

    public string? ShareOfTemporaryCropsFromAgriTotalOsb { get; set; }

    public string? ShareOfOtherAgricultureFromAgriTotalOsb { get; set; }

    public string? ShareOfMnfgOfCementsWoodAndPrintingsFromIndTotalOsb { get; set; }

    public string? ShareOfManfgOfFoodAndBeverageFromIndTotalOsb { get; set; }

    public string? ShareOfMnfgOfPlasticMetalAndMachEquipFromIndTotalOsb { get; set; }

    public string? ShareOfMnfgOfTextileChemicalsAndMedEquipFromIndTotalOsb { get; set; }

    public string? ShareOfMiningAndQuarryingFromIndTotalOsb { get; set; }

    public string? ShareOfOtherManufacturingFromIndTotalOsb { get; set; }

    public string? ShareOfHealthAndEducationFromDtsTotalOsb { get; set; }

    public string? ShareOfHotelAndTourismFromDtsTotalOsb { get; set; }

    public string? ShareOfTranspnAndCommnFromDtsTotalOsb { get; set; }

    public string? ShareOfWholesaleAndRetailFromDtsTotalOsb { get; set; }

    public string? ShareOfOtherServicesFromDtsTotalOsb { get; set; }

    public string? ShareOfImportsFromIntTradeTotalOsb { get; set; }

    public string? ShareOfExportsFromIntTradeTotalOsb { get; set; }

    public string? ShareOfConsnOfBldgAndInfralDevtFromBldgAndConTotalOsb { get; set; }

    public string? ShareOfRealEstateFromBldgAndConTotalOsb { get; set; }

    public string? ShareOfOthersFromBldgAndConTotalOsb { get; set; }

    public string? ShareOfHeadofficeFromTheBanksTotalOsb { get; set; }

    public string? ShareOfCentralRegionFromTheBanksTotalOsb { get; set; }

    public string? ShareOfNorthEastRegionFromTheBanksTotalOsb { get; set; }

    public string? ShareOfSouthWestRegionFromTheBanksTotalOsb { get; set; }

    public string? ShareOfTermLoansFromTotalOsb { get; set; }

    public string? ShareOfOverdraftFromTotalOsb { get; set; }

    public string? ShareOfMerchandizeLoanFromTotalOsb { get; set; }

    public string? ShareOfIfbFromTotalOsb { get; set; }

    public string? ShareOfAdvanceLoansFromTotalOsb { get; set; }

    public string? ShareOfLongTermLoansFromTotalOsb { get; set; }

    public string? ShareOfMediumTermLoansFromTotalOsb { get; set; }

    public string? ShareOfShortTermLoansFromTotalOsb { get; set; }

    public string? ShareOfLoansToRetailersFromTotalOsb { get; set; }

    public string? ShareOfLoansToWholesalersFromTotalOsb { get; set; }

    public string? ShareOfLoansToIfbCustomersFromTotalOsb { get; set; }

    public string? ShareOfLoansAndAdvanceFromTotalCredit { get; set; }

    public string? ShareOfBondsFromTotalCredit { get; set; }

    public string? NPlsAgainstTotalOsb { get; set; }

    public string? ZeroDaysArrearsAgainstTotalOsb { get; set; }

    public string? One8DaysArrearsAgainstTotalOsb { get; set; }

    public string? Eight29DaysArrearsAgainstTotalOsb { get; set; }

    public string? ShareOfSpecialMentionFromTotalOsb { get; set; }

    public int? Status { get; set; }

    public string? History { get; set; }

    public string? Description { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual RariskLevel? RiskLevel { get; set; }
}
