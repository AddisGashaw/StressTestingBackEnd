using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RacreditCorporate
{
    public int Id { get; set; }

    public string AccYear { get; set; } = null!;

    public string AccQuarter { get; set; } = null!;

    public string? CreditOneSingleBorrowerUnrelatedToCbePrincipalOutstandingBalance { get; set; }

    public string? CreditSingleBorrowerUnrelatedToCbePrincipalOutstandingBalance { get; set; }

    public string? CreditOneRelatedPartyPrincipalOutstandingBalance { get; set; }

    public string? CreditAllRelatedPartiesPrincipalOutstandingBalance { get; set; }

    public string? CreditTop10BorrowersPrincipalOutstandingBalance { get; set; }

    public string? CreditTop100BorrowersPrincipalOutstandingBalance { get; set; }

    public string? CreditTop200BorrowersPrincipalOutstandingBalance { get; set; }

    public string? CreditAgriculturePrincipalOutstandingBalance { get; set; }

    public string? CreditBuildingAndConstructionsPrincipalOutstandingBalance { get; set; }

    public string? CreditDomesticTradeAndServicesPrincipalOutstandingBalance { get; set; }

    public string? CreditIndustryPrincipalOutstandingBalance { get; set; }

    public string? CreditInternationalTradePrincipalOutstandingBalance { get; set; }

    public string? CreditFinancialInstitutionsPrincipalOutstandingBalance { get; set; }

    public string? CreditOthersPrincipalOutstandingBalance { get; set; }

    public string? CreditConsumerLoanPrincipalOutstandingBalance { get; set; }

    public string? CreditAnimalHusbandryPrincipalOutstandingBalance { get; set; }

    public string? CreditPermanentCropsPrincipalOutstandingBalance { get; set; }

    public string? CreditTemporaryCropsPrincipalOutstandingBalance { get; set; }

    public string? CreditOtherAgriculturePrincipalOutstandingBalance { get; set; }

    public string? CreditManufacturingOfCementsWoodAndPrintingsPrincipalOutstandingBalance { get; set; }

    public string? CreditManufacturingOfFoodAndBeveragePrincipalOutstandingBalance { get; set; }

    public string? CreditManufacturingOfPlasticMetalAndMachineryEquipmentPrincipalOutstandingBalance { get; set; }

    public string? CreditManufacturingOfTextileChemicalsAndMedicalEquipmentPrincipalOutstandingBalance { get; set; }

    public string? CreditMiningAndQuarryingPrincipalOutstandingBalance { get; set; }

    public string? CreditOtherManufacturingPrincipalOutstandingBalance { get; set; }

    public string? CreditHealthAndEducationPrincipalOutstandingBalance { get; set; }

    public string? CreditHotelAndTourismPrincipalOutstandingBalance { get; set; }

    public string? CreditTransportationAndCommunicationPrincipalOutstandingBalance { get; set; }

    public string? CreditWholesaleAndRetailPrincipalOutstandingBalance { get; set; }

    public string? CreditOtherServicesPrincipalOutstandingBalance { get; set; }

    public string? CreditImportsPrincipalOutstandingBalance { get; set; }

    public string? CreditExportsPrincipalOutstandingBalance { get; set; }

    public string? CreditConstructionOfBuildingsAndInfrastructureDevelopmentPrincipalOutstandingBalance { get; set; }

    public string? CreditRealEstatePrincipalOutstandingBalance { get; set; }

    public string? CreditOtherBuildingsPrincipalOutstandingBalance { get; set; }

    public string? CreditHeadOfficePrincipalOutstandingBalance { get; set; }

    public string? CreditCentralRegionPrincipalOutstandingBalance { get; set; }

    public string? CreditNorthEastRegionPrincipalOutstandingBalance { get; set; }

    public string? CreditSouthWestRegionPrincipalOutstandingBalance { get; set; }

    public string? CreditTermLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditOverdraftPrincipalOutstandingBalance { get; set; }

    public string? CreditMerchandiseLoanPrincipalOutstandingBalance { get; set; }

    public string? CreditIfbOutstandingBalance { get; set; }

    public string? CreditAdvanceLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditLongTermLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditMediumTermLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditShortTermLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditLoansToRetailersPrincipalOutstandingBalance { get; set; }

    public string? CreditLoansToWholesalersPrincipalOutstandingBalance { get; set; }

    public string? CreditLoansToIfbCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditLoansAndAdvancePrincipalOutstandingBalance { get; set; }

    public string? CreditBondsPrincipalOutstandingBalance { get; set; }

    public string? CreditNplsTotalPrincipalOutstandingBalance { get; set; }

    public string? CreditZeroDaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? Credit18DaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? Credit829DaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? CreditSpecialMentionPrincipalOutstandingBalance { get; set; }

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
