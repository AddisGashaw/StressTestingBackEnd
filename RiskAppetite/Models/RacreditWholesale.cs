using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RacreditWholesale
{
    public int Id { get; set; }

    public string AccYear { get; set; } = null!;

    public string AccQuarter { get; set; } = null!;

    public string? CreditTop10WholesaleBorrowersPrincipalOutstandingBalance { get; set; }

    public string? CreditTop100WholesaleBorrowersPrincipalOutstandingBalance { get; set; }

    public string? CreditTop200WholesaleBorrowersPrincipalOutstandingBalance { get; set; }

    public string? CreditAgriculturePrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditBuildingAndConPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditDtsPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditIndustryPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditIntTradePrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditFinancialInstPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditOthersPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditAnimalHusbandryPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditPermanentCropsPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditTemporaryCropsPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditOtherAgriculturePrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditMnfgOfCementsWoodAndPrintingsPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditManfGOfFoodAndBeveragePrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditMnfgOfPlasticMetalAndMachEquipPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditMnfGOfTextileChemicalsAndMedEquipPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditMiningAndQuarryingPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditOtherManufacturingPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditHealthAndEducationPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditHotelAndTourismPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditTranspTAndCommNPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditWholesaleAndRetailPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditOtherServicesPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditImportsPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditExportsPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditConsNOfBldgAndInfraLDevTPrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditRealEstatePrincipalOutstandingBalanceWholesale { get; set; }

    public string? CreditOthersPrincipalOutstandingBalanceWholesales { get; set; }

    public string? CreditHeadOfficeWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditCentralRegionWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditNorthEastRegionWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditSouthWestRegionWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditTermLoansWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditOverdraftWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditMerchandizeLoanWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditIfbWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditAdvanceLoansWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditLongTermWholesaleLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditMediumTermWholesaleLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditShortTermWholesaleLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditCorporateWholesaleCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditMicroCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditSmeCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditPublicAndInstAlCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditNplsWholesalePrincipalOutstandingBalance { get; set; }

    public string? Credit0DaysArrearsWholesalePrincipalOutstandingBalance { get; set; }

    public string? Credit18DaysArrearsWholesalePrincipalOutstandingBalance { get; set; }

    public string? Credit829DaysArrearsWholesalePrincipalOutstandingBalance { get; set; }

    public string? CreditSpecialMentionWholesalePrincipalOutstandingBalance { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? Statuses { get; set; }

    public string? Descriptions { get; set; }

    public string? History { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
