using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RiskAppetite.Model;

public partial class RiskApetiteContext : DbContext
{
    public RiskApetiteContext()
    {
    }

    public RiskApetiteContext(DbContextOptions<RiskApetiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apcredit> Apcredits { get; set; }

    public virtual DbSet<MarketRisk> MarketRisks { get; set; }

    public virtual DbSet<OprationalRisk> OprationalRisks { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SdbactualFinancialStatement> SdbactualFinancialStatements { get; set; }

    public virtual DbSet<Sdbcredit> Sdbcredits { get; set; }

    public virtual DbSet<SdbforcastFinancialStatment> SdbforcastFinancialStatments { get; set; }

    public virtual DbSet<Sdbliquidity> Sdbliquidities { get; set; }

    public virtual DbSet<SebactualFinancialStatement> SebactualFinancialStatements { get; set; }

    public virtual DbSet<SebcreditRisk> SebcreditRisks { get; set; }

    public virtual DbSet<SebforcastedFinancialStatement> SebforcastedFinancialStatements { get; set; }

    public virtual DbSet<SebliquidityRisk> SebliquidityRisks { get; set; }

    public virtual DbSet<Sebmacroeconomic> Sebmacroeconomics { get; set; }

    public virtual DbSet<SebmarketRisk> SebmarketRisks { get; set; }

    public virtual DbSet<Severity> Severities { get; set; }

    public virtual DbSet<SeverityForAnalysis> SeverityForAnalyses { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apcredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_credit");

            entity.ToTable("APCredit");

            entity.Property(e => e.AdamaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Adama_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.AdamaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Adama_District_Retail_O_S_B");
            entity.Property(e => e.AdamaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Adama_District_Wholesale_O_S_B");
            entity.Property(e => e.AdvanceLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Advance_Loans_O_S_B");
            entity.Property(e => e.AdvanceLoansWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Advance_Loans_wholesale_O_S_B");
            entity.Property(e => e.AffluentRetailCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Affluent_Retail_customers_O_S_B");
            entity.Property(e => e.AgricultureOSB)
                .HasMaxLength(50)
                .HasColumnName("Agriculture_O_S_B");
            entity.Property(e => e.AgricultureOSBN)
                .HasMaxLength(50)
                .HasColumnName("Agriculture_O_S_B_N");
            entity.Property(e => e.AgricultureOSBW)
                .HasMaxLength(50)
                .HasColumnName("Agriculture_O_S_B_W");
            entity.Property(e => e.AkakiKalitiDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Akaki_Kaliti_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.AkakiKalitiDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Akaki_Kaliti_District_Retail_O_S_B");
            entity.Property(e => e.AkakiKalitiDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Akaki_Kaliti_District_Wholesale_O_S_B");
            entity.Property(e => e.AllRelatedParty)
                .HasMaxLength(50)
                .HasColumnName("All_Related_Party");
            entity.Property(e => e.AmboDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Ambo_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.AmboDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Ambo_District_Retail_O_S_B");
            entity.Property(e => e.AmboDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Ambo_District_Wholesale_O_S_B");
            entity.Property(e => e.AnimalHusbandryOSB)
                .HasMaxLength(50)
                .HasColumnName("Animal_Husbandry_O_S_B");
            entity.Property(e => e.AnimalHusbandryOSBW)
                .HasMaxLength(50)
                .HasColumnName("Animal_Husbandry_O_S_B_W");
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.AradaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Arada_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.AradaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Arada_District_Retail_O_S_B");
            entity.Property(e => e.AradaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Arada_District_Wholesale_O_S_B");
            entity.Property(e => e.AsselaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Assela_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.AsselaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Assela_District_Retail_O_S_B");
            entity.Property(e => e.AsselaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Assela_District_Wholesale_O_S_B");
            entity.Property(e => e.BahirDarDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Bahir_Dar_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.BahirDarDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Bahir_Dar_District_Retail_O_S_B");
            entity.Property(e => e.BahirDarDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Bahir_Dar_District_Wholesale_O_S_B");
            entity.Property(e => e.BaiSalamFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Bai_Salam_Financings_O_S_B");
            entity.Property(e => e.BaleRobeDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Bale_Robe_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.BaleRobeDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Bale_Robe_District_Retail_O_S_B");
            entity.Property(e => e.BaleRobeDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Bale_Robe_District_Wholesale_O_S_B");
            entity.Property(e => e.BoleDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Bole_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.BoleDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Bole_District_Retail_O_S_B");
            entity.Property(e => e.BoleDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Bole_District_Wholesale_O_S_B");
            entity.Property(e => e.BondsFromTotalCredit)
                .HasMaxLength(50)
                .HasColumnName("Bonds_from_total_credit");
            entity.Property(e => e.BuildingAndConOSB)
                .HasMaxLength(50)
                .HasColumnName("Building_And_Con_O_S_B");
            entity.Property(e => e.BuildingAndConOSBN)
                .HasMaxLength(50)
                .HasColumnName("Building_And_Con_O_S_B_N");
            entity.Property(e => e.BuildingAndConOSBW)
                .HasMaxLength(50)
                .HasColumnName("Building_And_Con_O_S_B_W");
            entity.Property(e => e.CentralRegionCbeNoorFinancingOSB)
                .HasMaxLength(50)
                .HasColumnName("Central_Region_CBE_NOOR_Financing_O_S_B");
            entity.Property(e => e.CentralRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Central_Region_O_S_B");
            entity.Property(e => e.CentralRegionRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Central_Region_retail_loans_O_S_B");
            entity.Property(e => e.CentralRegionWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Central_Region_wholesale_O_S_B");
            entity.Property(e => e.ConsnOfBldgAndInfralDevtOSB)
                .HasMaxLength(50)
                .HasColumnName("Consn_of_BLDG_And_Infral_Devt_O_S_B");
            entity.Property(e => e.ConsnOfBldgAndInfralDevtOSBW)
                .HasMaxLength(50)
                .HasColumnName("Consn_of_BLDG_And_Infral_Devt_O_S_B_W");
            entity.Property(e => e.ConsumerLoanOSB)
                .HasMaxLength(50)
                .HasColumnName("Consumer_loan_O_S_B");
            entity.Property(e => e.ConsumerLoanOSBN)
                .HasMaxLength(50)
                .HasColumnName("Consumer_loan_O_S_B_N");
            entity.Property(e => e.CorporateWholesaleCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Corporate_wholesale_customers_O_S_B");
            entity.Property(e => e.DebrebirihanDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Debrebirihan_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.DebrebirihanDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Debrebirihan_District_Retail_O_S_B");
            entity.Property(e => e.DebrebirihanDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Debrebirihan_District_Wholesale_O_S_B");
            entity.Property(e => e.DebremarkosDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Debremarkos_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.DebremarkosDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Debremarkos_District_Retail_O_S_B");
            entity.Property(e => e.DebremarkosDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Debremarkos_District_Wholesale_O_S_B");
            entity.Property(e => e.DeliquentLoansAgainstOSB)
                .HasMaxLength(50)
                .HasColumnName("Deliquent_Loans_against_O_S_B");
            entity.Property(e => e.DeliquentLoansAgainstOSBN)
                .HasMaxLength(50)
                .HasColumnName("Deliquent_Loans_against_O_S_B_N");
            entity.Property(e => e.DeliquentLoansAgainstOSBR)
                .HasMaxLength(50)
                .HasColumnName("Deliquent_Loans_against_O_S_B_R");
            entity.Property(e => e.DeliquentLoansAgainstOSBW)
                .HasMaxLength(50)
                .HasColumnName("Deliquent_Loans_against_O_S_B_W");
            entity.Property(e => e.DessieDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Dessie_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.DessieDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Dessie_District_Retail_O_S_B");
            entity.Property(e => e.DessieDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Dessie_District_Wholesale_O_S_B");
            entity.Property(e => e.DillaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Dilla_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.DillaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Dilla_District_Retail_O_S_B");
            entity.Property(e => e.DillaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Dilla_District_Wholesale_O_S_B");
            entity.Property(e => e.DireDawaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Dire_Dawa_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.DireDawaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Dire_Dawa_District_Retail_O_S_B");
            entity.Property(e => e.DireDawaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Dire_Dawa_District_Wholesale_O_S_B");
            entity.Property(e => e.DtsOSB)
                .HasMaxLength(50)
                .HasColumnName("DTS_O_S_B");
            entity.Property(e => e.DtsOSBN)
                .HasMaxLength(50)
                .HasColumnName("DTS_O_S_B_N");
            entity.Property(e => e.DtsOSBW)
                .HasMaxLength(50)
                .HasColumnName("DTS_O_S_B_W");
            entity.Property(e => e.Eight29DaysArrearsR)
                .HasMaxLength(50)
                .HasColumnName("Eight_29_days_Arrears_R");
            entity.Property(e => e.EightTo29DaysArrears)
                .HasMaxLength(50)
                .HasColumnName("Eight_To_29_days_Arrears");
            entity.Property(e => e.EightTo29DaysArrearsN)
                .HasMaxLength(50)
                .HasColumnName("Eight_To_29_days_Arrears_N");
            entity.Property(e => e.EightTo29DaysArrearsW)
                .HasMaxLength(50)
                .HasColumnName("Eight_To_29_days_Arrears_W");
            entity.Property(e => e.ExportsOSB)
                .HasMaxLength(50)
                .HasColumnName("Exports_O_S_B");
            entity.Property(e => e.ExportsOSBW)
                .HasMaxLength(50)
                .HasColumnName("Exports_O_S_B_W");
            entity.Property(e => e.FinancialInstOSB)
                .HasMaxLength(50)
                .HasColumnName("Financial_Inst_O_S_B");
            entity.Property(e => e.FinancialInstOSBW)
                .HasMaxLength(50)
                .HasColumnName("Financial_Inst_O_S_B_W");
            entity.Property(e => e.GondarDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Gondar_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.GondarDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Gondar_District_Retail_O_S_B");
            entity.Property(e => e.GondarDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Gondar_District_Wholesale_O_S_B");
            entity.Property(e => e.GulleleDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Gullele_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.GulleleDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Gullele_District_Retail_O_S_B");
            entity.Property(e => e.GulleleDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Gullele_District_Wholesale_O_S_B");
            entity.Property(e => e.HawassaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Hawassa_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.HawassaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Hawassa_District_Retail_O_S_B");
            entity.Property(e => e.HawassaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Hawassa_District_Wholesale_O_S_B");
            entity.Property(e => e.HealthAndEducationOSB)
                .HasMaxLength(50)
                .HasColumnName("Health_And_Education_O_S_B");
            entity.Property(e => e.HealthAndEducationOSBW)
                .HasMaxLength(50)
                .HasColumnName("Health_And_Education_O_S_B_W");
            entity.Property(e => e.HossanaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Hossana_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.HossanaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Hossana_District_Retail_O_S_B");
            entity.Property(e => e.HossanaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Hossana_District_Wholesale_O_S_B");
            entity.Property(e => e.HotelAndTourismOSB)
                .HasMaxLength(50)
                .HasColumnName("Hotel_And_Tourism_O_S_B");
            entity.Property(e => e.HotelAndTourismOSBW)
                .HasMaxLength(50)
                .HasColumnName("Hotel_And_Tourism_O_S_B_W");
            entity.Property(e => e.IjarahFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Ijarah_Financings_O_S_B");
            entity.Property(e => e.ImportsOSB)
                .HasMaxLength(50)
                .HasColumnName("Imports_O_S_B");
            entity.Property(e => e.ImportsOSBW)
                .HasMaxLength(50)
                .HasColumnName("Imports_O_S_B_W");
            entity.Property(e => e.IndustryOSB)
                .HasMaxLength(50)
                .HasColumnName("Industry_O_S_B");
            entity.Property(e => e.IndustryOSBN)
                .HasMaxLength(50)
                .HasColumnName("Industry_O_S_B_N");
            entity.Property(e => e.IndustryOSBW)
                .HasMaxLength(50)
                .HasColumnName("Industry_O_S_B_W");
            entity.Property(e => e.IntTradeOSB)
                .HasMaxLength(50)
                .HasColumnName("Int_Trade_O_S_B");
            entity.Property(e => e.IntTradeOSBN)
                .HasMaxLength(50)
                .HasColumnName("Int_Trade_O_S_B_N");
            entity.Property(e => e.IntTradeOSBW)
                .HasMaxLength(50)
                .HasColumnName("Int_Trade_O_S_B_W");
            entity.Property(e => e.IstisnaFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Istisna_Financings_O_S_B");
            entity.Property(e => e.JigJigaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("JigJiga_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.JigJigaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("JigJiga_District_Retail_O_S_B");
            entity.Property(e => e.JigJigaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("JigJiga_District_Wholesale_O_S_B");
            entity.Property(e => e.JimmaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Jimma_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.JimmaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Jimma_District_Retail_O_S_B");
            entity.Property(e => e.JimmaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Jimma_District_Wholesale_O_S_B");
            entity.Property(e => e.KirkosDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Kirkos_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.KirkosDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Kirkos_District_Retail_O_S_B");
            entity.Property(e => e.KirkosDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Kirkos_District_Wholesale_O_S_B");
            entity.Property(e => e.KolfeDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Kolfe_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.KolfeDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Kolfe_District_Retail_O_S_B");
            entity.Property(e => e.KolfeDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Kolfe_District_Wholesale_O_S_B");
            entity.Property(e => e.LoansAndAdvanceOSB)
                .HasMaxLength(50)
                .HasColumnName("Loans_and_Advance_O_S_B");
            entity.Property(e => e.LoansToIfbCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Loans_to_IFB_customers_O_S_B");
            entity.Property(e => e.LoansToRetailersOSB)
                .HasMaxLength(50)
                .HasColumnName("Loans_to_Retailers_O_S_B");
            entity.Property(e => e.LoansToWholesalersOSB)
                .HasMaxLength(50)
                .HasColumnName("Loans_to_Wholesalers_O_S_B");
            entity.Property(e => e.LongTermFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Long_term_Financings_O_S_B");
            entity.Property(e => e.LongTermLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Long_term_loans_O_S_B");
            entity.Property(e => e.LongTermRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Long_term_retail_loans_O_S_B");
            entity.Property(e => e.LongTermWholesaleLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Long_term_wholesale_Loans_O_S_B");
            entity.Property(e => e.ManfgOfFoodAndBeverageOSB)
                .HasMaxLength(50)
                .HasColumnName("Manfg_of_Food_And_Beverage_O_S_B");
            entity.Property(e => e.ManfgOfFoodAndBeverageOSBW)
                .HasMaxLength(50)
                .HasColumnName("Manfg_of_Food_And_Beverage_O_S_B_W");
            entity.Property(e => e.MassRetailCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Mass_Retail_customers_O_S_B");
            entity.Property(e => e.MediumTermFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Medium_Term_Financings_O_S_B");
            entity.Property(e => e.MediumTermLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Medium_Term_loans_O_S_B");
            entity.Property(e => e.MediumTermRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Medium_Term_Retail_loans_O_S_B");
            entity.Property(e => e.MediumTermwholesaleLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Medium_Termwholesale_Loans_O_S_B");
            entity.Property(e => e.MegenagnaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Megenagna_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.MegenagnaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Megenagna_District_Retail_O_S_B");
            entity.Property(e => e.MegenagnaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Megenagna_District_Wholesale_O_S_B");
            entity.Property(e => e.MekelleDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Mekelle_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.MekelleDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Mekelle_District_Retail_O_S_B");
            entity.Property(e => e.MekelleDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Mekelle_District_Wholesale_O_S_B");
            entity.Property(e => e.MerchandizeLoanOSB)
                .HasMaxLength(50)
                .HasColumnName("Merchandize_loan_O_S_B");
            entity.Property(e => e.MerchandizeLoanWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Merchandize_loan_wholesale_O_S_B");
            entity.Property(e => e.MerkatoDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Merkato_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.MerkatoDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Merkato_District_Retail_O_S_B");
            entity.Property(e => e.MerkatoDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Merkato_District_Wholesale_O_S_B");
            entity.Property(e => e.MetuDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Metu_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.MetuDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Metu_District_Retail_O_S_B");
            entity.Property(e => e.MetuDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Metu_District_Wholesale_O_S_B");
            entity.Property(e => e.MicroWholesaleCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Micro_wholesale_customers_O_S_B");
            entity.Property(e => e.MiddleRetailCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Middle_Retail_customers_O_S_B");
            entity.Property(e => e.MiningAndQuarryingOSB)
                .HasMaxLength(50)
                .HasColumnName("Mining_And_Quarrying_O_S_B");
            entity.Property(e => e.MiningAndQuarryingOSBW)
                .HasMaxLength(50)
                .HasColumnName("Mining_And_Quarrying_O_S_B_W");
            entity.Property(e => e.MnfgOfCementsWoodAndPrintingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Mnfg_of_Cements_Wood_And_Printings_O_S_B");
            entity.Property(e => e.MnfgOfCementsWoodAndPrintingsOSBW)
                .HasMaxLength(50)
                .HasColumnName("Mnfg_of_Cements_Wood_And_Printings_O_S_B_W");
            entity.Property(e => e.MnfgOfPlasticMetalAndMachEquipOSB)
                .HasMaxLength(50)
                .HasColumnName("Mnfg_of_Plastic_Metal_And_Mach_Equip_O_S_B");
            entity.Property(e => e.MnfgOfPlasticMetalAndMachEquipOSBW)
                .HasMaxLength(50)
                .HasColumnName("Mnfg_of_Plastic_Metal_And_Mach_Equip_O_S_B_W");
            entity.Property(e => e.MnfgOfTextileChemicalsAndMedEquipOSB)
                .HasMaxLength(50)
                .HasColumnName("Mnfg_of_Textile_Chemicals_And_Med_Equip_O_S_B");
            entity.Property(e => e.MnfgOfTextileChemicalsAndMedEquipOSBW)
                .HasMaxLength(50)
                .HasColumnName("Mnfg_of_Textile_Chemicals_And_Med_Equip_O_S_B_W");
            entity.Property(e => e.MurabahaFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Murabaha_Financings_O_S_B");
            entity.Property(e => e.NefasSilkDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Nefas_Silk_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.NefasSilkDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Nefas_Silk_District_Retail_O_S_B");
            entity.Property(e => e.NefasSilkDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Nefas_Silk_District_Wholesale_O_S_B");
            entity.Property(e => e.NekemteDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Nekemte_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.NekemteDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Nekemte_District_Retail_O_S_B");
            entity.Property(e => e.NekemteDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Nekemte_District_Wholesale_O_S_B");
            entity.Property(e => e.NorthEastRegionCbeNoorFinancingOSB)
                .HasMaxLength(50)
                .HasColumnName("North_East_Region_CBE_NOOR_Financing_O_S_B");
            entity.Property(e => e.NorthEastRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("North_East_Region_O_S_B");
            entity.Property(e => e.NorthEastRegionRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("North_East_Region_retail_loans_O_S_B");
            entity.Property(e => e.NorthEastRegionWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("North_East_Region_wholesale_O_S_B");
            entity.Property(e => e.NplsAgainstTotalOSB)
                .HasMaxLength(50)
                .HasColumnName("NPLs_against_Total_O_S_B");
            entity.Property(e => e.NplsAgainstTotalOSBN)
                .HasMaxLength(50)
                .HasColumnName("NPLs_against_Total_O_S_B_N");
            entity.Property(e => e.NplsAgainstTotalOSBR)
                .HasMaxLength(50)
                .HasColumnName("NPLs_against_Total_O_S_B_R");
            entity.Property(e => e.NplsAgainstTotalOSBW)
                .HasMaxLength(50)
                .HasColumnName("NPLs_against_Total_O_S_B_W");
            entity.Property(e => e.One8DaysArrearsR)
                .HasMaxLength(50)
                .HasColumnName("One_8_days_Arrears_R");
            entity.Property(e => e.OneBorrowerUnrelated)
                .HasMaxLength(50)
                .HasColumnName("One_Borrower_Unrelated");
            entity.Property(e => e.OneRelatedParty)
                .HasMaxLength(50)
                .HasColumnName("One_Related_Party");
            entity.Property(e => e.OneTo8DaysArrears)
                .HasMaxLength(50)
                .HasColumnName("One_To_8_days_Arrears");
            entity.Property(e => e.OneTo8DaysArrearsN)
                .HasMaxLength(50)
                .HasColumnName("One_To_8_days_Arrears_N");
            entity.Property(e => e.OneTo8DaysArrearsW)
                .HasMaxLength(50)
                .HasColumnName("One_To_8_days_Arrears_W");
            entity.Property(e => e.OtherAgricultureOSB)
                .HasMaxLength(50)
                .HasColumnName("Other_Agriculture_O_S_B");
            entity.Property(e => e.OtherAgricultureOSBW)
                .HasMaxLength(50)
                .HasColumnName("Other_Agriculture_O_S_B_W");
            entity.Property(e => e.OtherFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Other_Financings_O_S_B");
            entity.Property(e => e.OtherManufacturingOSB)
                .HasMaxLength(50)
                .HasColumnName("Other_Manufacturing_O_S_B");
            entity.Property(e => e.OtherManufacturingOSBW)
                .HasMaxLength(50)
                .HasColumnName("Other_Manufacturing_O_S_B_W");
            entity.Property(e => e.OtherServicesOSB)
                .HasMaxLength(50)
                .HasColumnName("Other_Services_O_S_B");
            entity.Property(e => e.OtherServicesOSBW)
                .HasMaxLength(50)
                .HasColumnName("Other_Services_O_S_B_W");
            entity.Property(e => e.OthersOSB)
                .HasMaxLength(50)
                .HasColumnName("Others_O_S_B");
            entity.Property(e => e.OthersOSBW)
                .HasMaxLength(50)
                .HasColumnName("Others_O_S_B_W");
            entity.Property(e => e.OverdraftOSB)
                .HasMaxLength(50)
                .HasColumnName("Overdraft_O_S_B");
            entity.Property(e => e.OverdraftRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Overdraft_Retail_loans_O_S_B");
            entity.Property(e => e.OverdraftWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Overdraft_wholesale_O_S_B");
            entity.Property(e => e.PermanentCropsOSB)
                .HasMaxLength(50)
                .HasColumnName("Permanent_Crops_O_S_B");
            entity.Property(e => e.PermanentCropsOSBW)
                .HasMaxLength(50)
                .HasColumnName("Permanent_Crops_O_S_B_W");
            entity.Property(e => e.PublicAndInstalWholesaleCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("Public_And_instal_wholesale_customers_O_S_B");
            entity.Property(e => e.QerdFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Qerd_Financings_O_S_B");
            entity.Property(e => e.RealEstateOSB)
                .HasMaxLength(50)
                .HasColumnName("Real_estate_O_S_B");
            entity.Property(e => e.RealEstateOSBW)
                .HasMaxLength(50)
                .HasColumnName("Real_estate_O_S_B_W");
            entity.Property(e => e.RetailFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Retail_Financings_O_S_B");
            entity.Property(e => e.RevolvingRetailCreditsOSB)
                .HasMaxLength(50)
                .HasColumnName("Revolving_Retail_credits_O_S_B");
            entity.Property(e => e.ShahsemeneDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Shahsemene_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.ShahsemeneDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Shahsemene_District_Retail_O_S_B");
            entity.Property(e => e.ShahsemeneDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Shahsemene_District_Wholesale_O_S_B");
            entity.Property(e => e.ShireDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Shire_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.ShireDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Shire_District_Retail_O_S_B");
            entity.Property(e => e.ShireDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Shire_District_Wholesale_O_S_B");
            entity.Property(e => e.ShortTermFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Short_Term_Financings_O_S_B");
            entity.Property(e => e.ShortTermLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Short_Term_loans_O_S_B");
            entity.Property(e => e.ShortTermRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Short_Term_retail_loans_O_S_B");
            entity.Property(e => e.ShortTermWholesaleLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Short_Term_wholesale_Loans_O_S_B");
            entity.Property(e => e.SingleUnrelatedBorrower)
                .HasMaxLength(50)
                .HasColumnName("Single_Unrelated_Borrower");
            entity.Property(e => e.SmeWholesaleCustomersOSB)
                .HasMaxLength(50)
                .HasColumnName("SME_wholesale_customers_O_S_B");
            entity.Property(e => e.SouthWestRegionCbeNoorFinancingOSB)
                .HasMaxLength(50)
                .HasColumnName("South_West_Region_CBE_NOOR_Financing_O_S_B");
            entity.Property(e => e.SouthWestRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("South_West_Region_O_S_B");
            entity.Property(e => e.SouthWestRegionRetailLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("South_West_Region_retail_loans_O_S_B");
            entity.Property(e => e.SouthWestRegionWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("South_West_Region_wholesale_O_S_B");
            entity.Property(e => e.SpecialMentionOSB)
                .HasMaxLength(50)
                .HasColumnName("Special_Mention_O_S_B");
            entity.Property(e => e.SpecialMentionOSBN)
                .HasMaxLength(50)
                .HasColumnName("Special_Mention_O_S_B_N");
            entity.Property(e => e.SpecialMentionOSBR)
                .HasMaxLength(50)
                .HasColumnName("Special_Mention_O_S_B_R");
            entity.Property(e => e.SpecialMentionOSBW)
                .HasMaxLength(50)
                .HasColumnName("Special_Mention_O_S_B_W");
            entity.Property(e => e.TemporaryCropsOSB)
                .HasMaxLength(50)
                .HasColumnName("Temporary_Crops_O_S_B");
            entity.Property(e => e.TemporaryCropsOSBW)
                .HasMaxLength(50)
                .HasColumnName("Temporary_Crops_O_S_B_W");
            entity.Property(e => e.TermLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("Term_loans_O_S_B");
            entity.Property(e => e.TermLoansRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Term_loans_Retail_O_S_B");
            entity.Property(e => e.TermLoansWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Term_loans_wholesale_O_S_B");
            entity.Property(e => e.Top10)
                .HasMaxLength(50)
                .HasColumnName("Top_10");
            entity.Property(e => e.Top100)
                .HasMaxLength(50)
                .HasColumnName("Top_100");
            entity.Property(e => e.Top100WholesaleBorrowersOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_100_Wholesale_borrowers_O_S_B");
            entity.Property(e => e.Top10CbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_10_CBE_NOOR_O_S_B");
            entity.Property(e => e.Top10NpWholesaleLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("top_10_NP_Wholesale_loans_O_S_B");
            entity.Property(e => e.Top10Npfs)
                .HasMaxLength(50)
                .HasColumnName("top_10_NPFs");
            entity.Property(e => e.Top10NplsOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_10_NPLs_O_S_B");
            entity.Property(e => e.Top10WholesaleBorrowersOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_10_Wholesale_borrowers_O_S_B");
            entity.Property(e => e.Top200)
                .HasMaxLength(50)
                .HasColumnName("Top_200");
            entity.Property(e => e.Top200WholesaleBorrowersOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_200_Wholesale_borrowers_O_S_B");
            entity.Property(e => e.Top20CbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_20_CBE_NOOR_O_S_B");
            entity.Property(e => e.Top50CbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_50_CBE_NOOR_O_S_B");
            entity.Property(e => e.Top5NpWholesaleLoansOSB)
                .HasMaxLength(50)
                .HasColumnName("top_5_NP_Wholesale_loans_O_S_B");
            entity.Property(e => e.Top5Npfs)
                .HasMaxLength(50)
                .HasColumnName("top_5_NPFs");
            entity.Property(e => e.Top5NplsOSB)
                .HasMaxLength(50)
                .HasColumnName("Top_5_NPLs_O_S_B");
            entity.Property(e => e.TotalCapital)
                .HasMaxLength(50)
                .HasColumnName("Total_Capital");
            entity.Property(e => e.TotalCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_CBE_NOOR_O_S_B");
            entity.Property(e => e.TotalCentralRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Central_Region_O_S_B");
            entity.Property(e => e.TotalCredit)
                .HasMaxLength(50)
                .HasColumnName("Total_Credit");
            entity.Property(e => e.TotalIfbCentralRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_IFB_Central_Region_O_S_B");
            entity.Property(e => e.TotalIfbNorthEastRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_IFB_North_east_region_O_S_B");
            entity.Property(e => e.TotalIfbSouthWestRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_IFB_South_west_Region_O_S_B");
            entity.Property(e => e.TotalNorthEastRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_North_east_region_O_S_B");
            entity.Property(e => e.TotalNplsOfTheBank)
                .HasMaxLength(50)
                .HasColumnName("Total_NPLs_of_the_bank");
            entity.Property(e => e.TotalOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_O_S_B");
            entity.Property(e => e.TotalPrivateLoansAndAdvances)
                .HasMaxLength(50)
                .HasColumnName("Total_Private_Loans_and_Advances");
            entity.Property(e => e.TotalRetailCentralRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Retail_Central_Region_O_S_B");
            entity.Property(e => e.TotalRetailLoansAndAdvances)
                .HasMaxLength(50)
                .HasColumnName("Total_Retail_Loans_and_Advances");
            entity.Property(e => e.TotalRetailNorthEastRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Retail_North_east_region_O_S_B");
            entity.Property(e => e.TotalRetailSouthWestRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Retail_South_west_Region_O_S_B");
            entity.Property(e => e.TotalSouthWestRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_South_west_Region_O_S_B");
            entity.Property(e => e.TotalWholesaleCentralRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Wholesale_Central_Region_O_S_B");
            entity.Property(e => e.TotalWholesaleLoansAndAdvances)
                .HasMaxLength(50)
                .HasColumnName("Total_Wholesale_Loans_and_Advances");
            entity.Property(e => e.TotalWholesaleNorthEastRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Wholesale_North_east_region_O_S_B");
            entity.Property(e => e.TotalWholesaleSouthWestRegionOSB)
                .HasMaxLength(50)
                .HasColumnName("Total_Wholesale_South_west_Region_O_S_B");
            entity.Property(e => e.TranspnAndCommNOSB)
                .HasMaxLength(50)
                .HasColumnName("Transpn_And_Comm_n_O_S_B");
            entity.Property(e => e.TranspnAndCommnOSBW)
                .HasMaxLength(50)
                .HasColumnName("Transpn_And_Commn_O_S_B_W");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.WBOtherOSB)
                .HasMaxLength(50)
                .HasColumnName("W_B_Other_O_S_B");
            entity.Property(e => e.WBOthersOSBW)
                .HasMaxLength(50)
                .HasColumnName("W_B_Others_O_S_B_W");
            entity.Property(e => e.WholesaleAndRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Wholesale_And_Retail_O_S_B");
            entity.Property(e => e.WholesaleAndRetailOSBW)
                .HasMaxLength(50)
                .HasColumnName("Wholesale_And_Retail_O_S_B_W");
            entity.Property(e => e.WholesaleFinancingsOSB)
                .HasMaxLength(50)
                .HasColumnName("Wholesale_Financings_O_S_B");
            entity.Property(e => e.WolayitaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Wolayita_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.WolayitaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Wolayita_District_Retail_O_S_B");
            entity.Property(e => e.WolayitaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Wolayita_District_Wholesale_O_S_B");
            entity.Property(e => e.WoldiyaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Woldiya_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.WoldiyaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Woldiya_District_Retail_O_S_B");
            entity.Property(e => e.WoldiyaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Woldiya_District_Wholesale_O_S_B");
            entity.Property(e => e.YekaDistrictCbeNoorOSB)
                .HasMaxLength(50)
                .HasColumnName("Yeka_District_CBE_NOOR_O_S_B");
            entity.Property(e => e.YekaDistrictRetailOSB)
                .HasMaxLength(50)
                .HasColumnName("Yeka_District_Retail_O_S_B");
            entity.Property(e => e.YekaDistrictWholesaleOSB)
                .HasMaxLength(50)
                .HasColumnName("Yeka_District_Wholesale_O_S_B");
            entity.Property(e => e.ZeroDaysArrears)
                .HasMaxLength(50)
                .HasColumnName("Zero_days_Arrears");
            entity.Property(e => e.ZeroDaysArrearsN)
                .HasMaxLength(50)
                .HasColumnName("Zero_days_Arrears_N");
            entity.Property(e => e.ZeroDaysArrearsR)
                .HasMaxLength(50)
                .HasColumnName("Zero_days_Arrears_R");
            entity.Property(e => e.ZeroDaysArrearsW)
                .HasMaxLength(50)
                .HasColumnName("Zero_days_Arrears_W");
        });

        modelBuilder.Entity<MarketRisk>(entity =>
        {
            entity.ToTable("Market_risk");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.AssetByMaturityBucket13Months)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_1_3_months");
            entity.Property(e => e.AssetByMaturityBucket13Years)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_1_3_years");
            entity.Property(e => e.AssetByMaturityBucket15DaysTo1Month)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_15_days_to_1_month");
            entity.Property(e => e.AssetByMaturityBucket1Day)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_1_Day");
            entity.Property(e => e.AssetByMaturityBucket27Days)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_2_7_Days");
            entity.Property(e => e.AssetByMaturityBucket36Months)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_3_6_months");
            entity.Property(e => e.AssetByMaturityBucket612Months)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_6_12_months");
            entity.Property(e => e.AssetByMaturityBucket814Days)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_8_14_Days");
            entity.Property(e => e.AssetByMaturityBucketNonInterestSensitiveItems)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_Non_Interest_Sensitive_Items");
            entity.Property(e => e.AssetByMaturityBucketOver3Years)
                .HasMaxLength(50)
                .HasColumnName("Asset_by_Maturity_Bucket_Over_3_years");
            entity.Property(e => e.FcyCorrespondenOurAccountMillionUsdEquva)
                .HasMaxLength(50)
                .HasColumnName("FCY_Corresponden_Our_Account_million_USD_equva");
            entity.Property(e => e.FcyFcyAssetCashAndDepositByUsd)
                .HasMaxLength(50)
                .HasColumnName("FCY_FCY_Asset_Cash_and_Deposit_by_USD");
            entity.Property(e => e.FcyOfBSAssetsInUsd)
                .HasMaxLength(50)
                .HasColumnName("FCY_Of_B_S_Assets_in_USD");
            entity.Property(e => e.FcyOffBSLiabilitiesInUsd)
                .HasMaxLength(50)
                .HasColumnName("FCY_Off_B_S_Liabilities_in_USD");
            entity.Property(e => e.FcyOnBSAssetsInOtherCurrenciesInBirr)
                .HasMaxLength(50)
                .HasColumnName("FCY_On_B_S_Assets_in_other_currencies_in_birr");
            entity.Property(e => e.FcyOnBSAssetsInUsd)
                .HasMaxLength(50)
                .HasColumnName("FCY_On_B_S_Assets_in_USD");
            entity.Property(e => e.FcyOnBSGuarantee)
                .HasMaxLength(50)
                .HasColumnName("FCY_On_B_S_Guarantee");
            entity.Property(e => e.FcyOnBSLetterOfCredit)
                .HasMaxLength(50)
                .HasColumnName("FCY_On_B_S_Letter_of_Credit");
            entity.Property(e => e.FcyOnBSLiabilitiesInOtherCurrenciesInBirr)
                .HasMaxLength(50)
                .HasColumnName("FCY_On_B_S_Liabilities_in_other_currencies_in_birr");
            entity.Property(e => e.FcyOnBSLiabilitiesInUsd)
                .HasMaxLength(50)
                .HasColumnName("FCY_On_B_S_Liabilities_in_USD");
            entity.Property(e => e.FxAssetOffBalanceSheetAssets)
                .HasMaxLength(50)
                .HasColumnName("FX_Asset_Off_Balance_Sheet_Assets");
            entity.Property(e => e.FxAssetOnBalanceSheetAssets)
                .HasMaxLength(50)
                .HasColumnName("FX_Asset_On_Balance_Sheet_Assets");
            entity.Property(e => e.FxLiabilityOffBalanceSheetLiabilities)
                .HasMaxLength(50)
                .HasColumnName("FX_Liability_Off_Balance_Sheet_Liabilities");
            entity.Property(e => e.FxLiabilityOnBalanceSheetLiabilities)
                .HasMaxLength(50)
                .HasColumnName("FX_Liability_On_Balance_Sheet_Liabilities");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket13Months)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_1_3_months");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket13Years)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_1_3_years");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket15DaysTo1Month)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_15_days_to_1_month");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket1Day)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_1_Day");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket27Days)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_2_7_Days");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket36Months)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_3_6_months");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket612Months)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_6_12_months");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucket814Days)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_8_14_Days");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucketNonInterestSensitiveItems)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_Non_Interest_Sensitive_Items");
            entity.Property(e => e.LiabilityAndEquaityByMaturityBucketOver3Years)
                .HasMaxLength(50)
                .HasColumnName("Liability_And_Equaity_by_Maturity_Bucket_Over_3_years");
            entity.Property(e => e.OfficialMarketRate)
                .HasMaxLength(50)
                .HasColumnName("Official_Market_Rate");
            entity.Property(e => e.OpenPositionByEurShort)
                .HasMaxLength(50)
                .HasColumnName("Open_Position_By_EUR_short");
            entity.Property(e => e.OpenPositionByOtherCurrencyShort)
                .HasMaxLength(50)
                .HasColumnName("Open_Position_By_Other_currency_short");
            entity.Property(e => e.OpenPositionByUsdShort)
                .HasMaxLength(50)
                .HasColumnName("Open_Position_By_USD_short");
            entity.Property(e => e.ParallelMarketRate)
                .HasMaxLength(50)
                .HasColumnName("Parallel_Market_Rate");
            entity.Property(e => e.Quarter).HasMaxLength(50);
            entity.Property(e => e.RateSensitiveAssets)
                .HasMaxLength(50)
                .HasColumnName("Rate_Sensitive_Assets");
            entity.Property(e => e.RateSensitiveAssetsThreeMonths)
                .HasMaxLength(50)
                .HasColumnName("Rate_Sensitive_Assets_Three_months");
            entity.Property(e => e.RateSensitiveLiabilities)
                .HasMaxLength(50)
                .HasColumnName("Rate_Sensitive_Liabilities");
            entity.Property(e => e.RateSensitiveLiabilitiesThreeMonths)
                .HasMaxLength(50)
                .HasColumnName("Rate_Sensitive_Liabilities_Three_months");
            entity.Property(e => e.TotalOfBSFcyLiabilitiesEur)
                .HasMaxLength(50)
                .HasColumnName("Total_Of_B_S_FCY_Liabilities_EUR");
            entity.Property(e => e.TotalOffBSFcyAssetsEur)
                .HasMaxLength(50)
                .HasColumnName("Total_Off_B_S_FCY_Assets_EUR");
            entity.Property(e => e.TotalOffBSFcyAssetsOtherCurrencies)
                .HasMaxLength(50)
                .HasColumnName("Total_Off_B_S_FCY_Assets_Other_currencies");
            entity.Property(e => e.TotalOffBSFcyAssetsUsd)
                .HasMaxLength(50)
                .HasColumnName("Total_Off_B_S_FCY_Assets_USD");
            entity.Property(e => e.TotalOffBSFcyLiabilitiesOtherCurrencies)
                .HasMaxLength(50)
                .HasColumnName("Total_Off_B_S_FCY_Liabilities_Other_currencies");
            entity.Property(e => e.TotalOffBSFcyLiabilitiesUsd)
                .HasMaxLength(50)
                .HasColumnName("Total_Off_B_S_FCY_Liabilities_USD");
            entity.Property(e => e.TotalOnBSFcyAssetsEur)
                .HasMaxLength(50)
                .HasColumnName("Total_On_B_S_FCY_Assets_EUR");
            entity.Property(e => e.TotalOnBSFcyAssetsOtherCurrencies)
                .HasMaxLength(50)
                .HasColumnName("Total_On_B_S_FCY_Assets_Other_currencies");
            entity.Property(e => e.TotalOnBSFcyAssetsUsd)
                .HasMaxLength(50)
                .HasColumnName("Total_On_B_S_FCY_Assets_USD");
            entity.Property(e => e.TotalOnBSFcyLiabilitiesEur)
                .HasMaxLength(50)
                .HasColumnName("Total_On_B_S_FCY_Liabilities_EUR");
            entity.Property(e => e.TotalOnBSFcyLiabilitiesOtherCurrencies)
                .HasMaxLength(50)
                .HasColumnName("Total_On_B_S_FCY_Liabilities_Other_currencies");
            entity.Property(e => e.TotalOnBSFcyLiabilitiesUsd)
                .HasMaxLength(50)
                .HasColumnName("Total_On_B_S_FCY_Liabilities_USD");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.UsdAgenistBirrBuyingRate)
                .HasMaxLength(50)
                .HasColumnName("USD_agenist_Birr_Buying_Rate");
            entity.Property(e => e.UsdAgenistBirrMidRate)
                .HasMaxLength(50)
                .HasColumnName("USD_agenist_Birr_Mid_Rate");
            entity.Property(e => e.UsdAgenistBirrSellingRate)
                .HasMaxLength(50)
                .HasColumnName("USD_agenist_Birr_Selling_Rate");
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<OprationalRisk>(entity =>
        {
            entity.ToTable("Oprational_risk");

            entity.Property(e => e.ActualIncidentsExternal)
                .HasMaxLength(50)
                .HasColumnName("Actual_Incidents_External");
            entity.Property(e => e.ActualIncidentsPeople)
                .HasMaxLength(50)
                .HasColumnName("Actual_Incidents_People");
            entity.Property(e => e.ActualIncidentsProcess)
                .HasMaxLength(50)
                .HasColumnName("Actual_Incidents_Process");
            entity.Property(e => e.ActualIncidentsSystem)
                .HasMaxLength(50)
                .HasColumnName("Actual_Incidents_System");
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.NearMissesExternal)
                .HasMaxLength(50)
                .HasColumnName("Near_Misses_External");
            entity.Property(e => e.NearMissesPeople)
                .HasMaxLength(50)
                .HasColumnName("Near_Misses_People");
            entity.Property(e => e.NearMissesProcess)
                .HasMaxLength(50)
                .HasColumnName("Near_Misses_Process");
            entity.Property(e => e.NearMissesSystem)
                .HasMaxLength(50)
                .HasColumnName("Near_Misses_System");
            entity.Property(e => e.NetInterestIncome).HasMaxLength(50);
            entity.Property(e => e.NetNonInterestIncome).HasMaxLength(50);
            entity.Property(e => e.Quarter).HasMaxLength(50);
            entity.Property(e => e.Revenue).HasMaxLength(50);
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.RoleName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(150);
        });

        modelBuilder.Entity<SdbactualFinancialStatement>(entity =>
        {
            entity.ToTable("SDBActualFinancialStatement");

            entity.Property(e => e.AccumulatedProfitOrLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Accumulated_profit_or_loss");
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.BondsSecuritiesInterestIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BONDS_SECURITIES_Interest_Income");
            entity.Property(e => e.BorrowingOrNationalBankLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Borrowing_or_National_Bank_Liabilities");
            entity.Property(e => e.Capital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CashAndCashEquivalent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cash_and_cash_equivalent");
            entity.Property(e => e.CbeNoorIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBE_NOOR_INCOME");
            entity.Property(e => e.CbeNoorReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBE_Noor_reserve");
            entity.Property(e => e.CommissionAndChargesIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMISSION_AND_CHARGES_Income");
            entity.Property(e => e.CustomersDeposits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customers_deposits");
            entity.Property(e => e.DebtAndEquitySecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debt_and_Equity_securities");
            entity.Property(e => e.DeferredTaxAsset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deferred_tax_asset");
            entity.Property(e => e.DepositsDueToOtherBanks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposits_Due_to_Other_Banks");
            entity.Property(e => e.Dividend)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeBenefitsObligation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_Benefits_Obligation");
            entity.Property(e => e.EmployeesBenefits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEES_BENEFITS");
            entity.Property(e => e.EmployeesProvisions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEES_PROVISIONS");
            entity.Property(e => e.EmployeesSalaries)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEES_SALARIES");
            entity.Property(e => e.FinanceLeaseObligations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Finance_lease_obligations");
            entity.Property(e => e.GainOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gain_On_FX");
            entity.Property(e => e.GeneralExpenses)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENERAL_EXPENSES");
            entity.Property(e => e.ImpairmentOnFinancialAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPAIRMENT_ON_FINANCIAL_ASSETS");
            entity.Property(e => e.IntangibleAssetsSoftwares)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Intangible_Assets_Softwares");
            entity.Property(e => e.InterestExpense)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTEREST_EXPENSE");
            entity.Property(e => e.InvestmentsInSubsidiariesAndAssociates)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Investments_in_subsidiaries_and_associates");
            entity.Property(e => e.LegalReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Legal_reserve");
            entity.Property(e => e.LoansAdvancesAndFinancingToCustomersNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_advances_and_Financing_to_customers_net");
            entity.Property(e => e.LoansAndAdvancesInterestIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOANS_AND_ADVANCES_Interest_Income");
            entity.Property(e => e.LoansToFinancialInstitutions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_to_Financial_institutions");
            entity.Property(e => e.LossOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOSS_ON_FX");
            entity.Property(e => e.MarginHeldPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Margin_Held_Payable");
            entity.Property(e => e.NonCurrentAssetsHeldForSaleNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Non_current_assets_held_for_sale_net");
            entity.Property(e => e.OffBsBidBondsPerformanceBonds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Off_Bs_Bid_bonds_Performance_Bonds");
            entity.Property(e => e.OffBsLetterOfCredit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Off_Bs_Letter_of_credit");
            entity.Property(e => e.OffBsLoansAndBondCom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Off_Bs_Loans_and_Bond_Com");
            entity.Property(e => e.OffBsLoansAndBondComGuarantedByCentralGov)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Off_Bs_Loans_and_Bond_Com_guaranted_by_central_gov");
            entity.Property(e => e.OffBsLoansComGuarnateedByRegionalGov)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Off_Bs_Loans_com_Guarnateed_by_regional_gov");
            entity.Property(e => e.OtherAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Assets");
            entity.Property(e => e.OtherComprehensiveIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Comprehensive_income");
            entity.Property(e => e.OtherIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTHER_INCOME");
            entity.Property(e => e.OtherLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Liabilities");
            entity.Property(e => e.ProfitLossBeforeTaxation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROFIT_LOSS_BEFORE_TAXATION");
            entity.Property(e => e.ProfitPaidToCbeNoorDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROFIT_PAID_TO_CBE_NOOR_DEPOSIT");
            entity.Property(e => e.PropertyPlantAndEquipmentNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Property_plant_and_equipment_net");
            entity.Property(e => e.ProvisionalProfitOrLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Provisional_profit_or_loss");
            entity.Property(e => e.Provisions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quarter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReceivablesNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Receivables_net");
            entity.Property(e => e.RegulatoryImpairmentReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Regulatory_Impairment_reserve");
            entity.Property(e => e.RightOfUseAssetsNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Right_of_use_assets_Net");
            entity.Property(e => e.TaxAndPensionPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tax_and_Pension_Payable");
            entity.Property(e => e.TotalOffBSheetRwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_Off_B_sheet_RWA");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sdbcredit>(entity =>
        {
            entity.ToTable("SDBCredit");

            entity.Property(e => e.AdjustedCommitment).HasMaxLength(50);
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.BidBondsPerformanceBonds)
                .HasMaxLength(50)
                .HasColumnName("Bid_bonds_Performance_Bonds");
            entity.Property(e => e.Csbl)
                .HasMaxLength(150)
                .HasColumnName("CSBL");
            entity.Property(e => e.DisbursementCouponCorporateBonds)
                .HasMaxLength(150)
                .HasColumnName("Disbursement_Coupon_Corporate_Bonds");
            entity.Property(e => e.DisbursementLoansAdv)
                .HasMaxLength(150)
                .HasColumnName("Disbursement_Loans_Adv");
            entity.Property(e => e.DoubtfulLoan)
                .HasMaxLength(150)
                .HasColumnName("Doubtful_Loan");
            entity.Property(e => e.LetterOfCredit)
                .HasMaxLength(50)
                .HasColumnName("Letter_of_credit");
            entity.Property(e => e.LoansAndBondCom)
                .HasMaxLength(50)
                .HasColumnName("Loans_and_Bond_Com");
            entity.Property(e => e.LoansAndBondComGuarantedByCentralGov)
                .HasMaxLength(50)
                .HasColumnName("Loans_and_Bond_Com_guaranted_by_central_gov");
            entity.Property(e => e.LoansComGuarnateedByRegionalGov)
                .HasMaxLength(50)
                .HasColumnName("Loans_Com_Guarnateed_by_regional_gov");
            entity.Property(e => e.LossLoan)
                .HasMaxLength(150)
                .HasColumnName("Loss_Loan");
            entity.Property(e => e.NcsblPrivAndCoop)
                .HasMaxLength(150)
                .HasColumnName("NCSBL_Priv_and_Coop");
            entity.Property(e => e.NplAgriculture)
                .HasMaxLength(150)
                .HasColumnName("NPL_Agriculture");
            entity.Property(e => e.NplBuildingAndConstruction)
                .HasMaxLength(150)
                .HasColumnName("NPL_Building_And_Construction");
            entity.Property(e => e.NplConsumerLoan)
                .HasMaxLength(150)
                .HasColumnName("NPL_Consumer_Loan");
            entity.Property(e => e.NplDomesticTradeAndService)
                .HasMaxLength(150)
                .HasColumnName("NPL_Domestic_Trade_And_Service");
            entity.Property(e => e.NplFinancialInstitutions)
                .HasMaxLength(150)
                .HasColumnName("NPL_Financial_Institutions");
            entity.Property(e => e.NplIndustries)
                .HasMaxLength(150)
                .HasColumnName("NPL_Industries");
            entity.Property(e => e.NplInternationalTrade)
                .HasMaxLength(150)
                .HasColumnName("NPL_International_Trade");
            entity.Property(e => e.NplOtherSector)
                .HasMaxLength(150)
                .HasColumnName("NPL_Other_Sector");
            entity.Property(e => e.PassLoan)
                .HasMaxLength(150)
                .HasColumnName("Pass_Loan");
            entity.Property(e => e.PrincipalCollectionActual)
                .HasMaxLength(50)
                .HasColumnName("Principal_Collection_Actual");
            entity.Property(e => e.PrincipalCollectionCoupAndCorpBonds)
                .HasMaxLength(150)
                .HasColumnName("Principal_Collection_Coup_and_Corp_Bonds");
            entity.Property(e => e.PrincipalCollectionLoansAndAdvances)
                .HasMaxLength(150)
                .HasColumnName("Principal_Collection_Loans_and_Advances");
            entity.Property(e => e.ProvisionForDoubtful)
                .HasMaxLength(150)
                .HasColumnName("Provision_for_Doubtful");
            entity.Property(e => e.ProvisionForLoss)
                .HasMaxLength(150)
                .HasColumnName("Provision_for_Loss");
            entity.Property(e => e.ProvisionForPass)
                .HasMaxLength(150)
                .HasColumnName("Provision_for_Pass");
            entity.Property(e => e.ProvisionForSpecialMention)
                .HasMaxLength(150)
                .HasColumnName("Provision_for_Special_Mention");
            entity.Property(e => e.ProvisionForSubstandard)
                .HasMaxLength(150)
                .HasColumnName("Provision_for_Substandard");
            entity.Property(e => e.Quarter).HasMaxLength(150);
            entity.Property(e => e.RecoveryRate1)
                .HasMaxLength(150)
                .HasColumnName("Recovery_Rate1");
            entity.Property(e => e.RecoveryRate2)
                .HasMaxLength(150)
                .HasColumnName("Recovery_Rate2");
            entity.Property(e => e.RecoveryRate3)
                .HasMaxLength(150)
                .HasColumnName("Recovery_Rate3");
            entity.Property(e => e.RiskWeightedAsset)
                .HasMaxLength(150)
                .HasColumnName("Risk_Weighted_Asset");
            entity.Property(e => e.SpecialMentionLoan)
                .HasMaxLength(150)
                .HasColumnName("Special_Mention_Loan");
            entity.Property(e => e.SubstandardLoan)
                .HasMaxLength(150)
                .HasColumnName("Substandard_Loan");
            entity.Property(e => e.Top100BorrowersOOrs)
                .HasMaxLength(150)
                .HasColumnName("Top_100_Borrowers_oORs");
            entity.Property(e => e.Top10BorrowersOOrs)
                .HasMaxLength(150)
                .HasColumnName("Top_10_Borrowers_oORs");
            entity.Property(e => e.TotalBondsCorpAndCoup)
                .HasMaxLength(150)
                .HasColumnName("Total_Bonds_CorpAndCoup");
            entity.Property(e => e.TotalDisbursement)
                .HasMaxLength(150)
                .HasColumnName("Total_Disbursement");
            entity.Property(e => e.TotalIncomeCbeNoorFinancing)
                .HasMaxLength(150)
                .HasColumnName("Total_Income_CBE_Noor_Financing");
            entity.Property(e => e.TotalInterestEarnedLoansAndAdv)
                .HasMaxLength(150)
                .HasColumnName("Total_Interest_Earned_Loans_and_Adv");
            entity.Property(e => e.TotalOffBSheetRwa)
                .HasMaxLength(50)
                .HasColumnName("Total_Off_B_sheet_RWA");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year).HasMaxLength(150);
        });

        modelBuilder.Entity<SdbforcastFinancialStatment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SDBForcastFinancialStat");

            entity.ToTable("SDBForcastFinancialStatment");

            entity.Property(e => e.AccruedInterestOnCouponBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Accrued_Interest_on_coupon_bond");
            entity.Property(e => e.AccruedInterestOnDbeBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Accrued_interest_on_DBE_bond");
            entity.Property(e => e.AccruedInterestOnLoansAndAdvance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Accrued_interest_on_loans_and_advance");
            entity.Property(e => e.AccumulatedProfitOrLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Accumulated_profit_or_loss");
            entity.Property(e => e.AirlinesService)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Airlines_service");
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.AssociationsDemand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Associations_demand");
            entity.Property(e => e.AssociationsSaving)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Associations_saving");
            entity.Property(e => e.AssociationsTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Associations_time");
            entity.Property(e => e.AssociationsTotalDepositByOwnership)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Associations_Total_deposit_by_ownership");
            entity.Property(e => e.Atlantic)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AtmPurchase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATM_purchase");
            entity.Property(e => e.BondsAndSecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Bonds_and_Securities");
            entity.Property(e => e.BorrowingNbeLiablities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Borrowing_NBE_liablities");
            entity.Property(e => e.BranchWPurchase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Branch_w_purchase");
            entity.Property(e => e.BusinessProfitTax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Business_profit_tax");
            entity.Property(e => e.Capital)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("capital");
            entity.Property(e => e.CashAndCashEquivalent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cash_and_cash_equivalent");
            entity.Property(e => e.CashExpress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cash_express");
            entity.Property(e => e.CbeNoorIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cbe_Noor_Income");
            entity.Property(e => e.CbeNoorReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cbe_noor_reserve");
            entity.Property(e => e.Coffee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("coffee");
            entity.Property(e => e.CommissionAndCharges)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Commission_and_Charges");
            entity.Property(e => e.CouponBondPrincipal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Coupon_bond_principal");
            entity.Property(e => e.CustomersDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customers_deposit");
            entity.Property(e => e.DbeBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBE_bond");
            entity.Property(e => e.DbeBondPurchase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBE_Bond_purchase");
            entity.Property(e => e.DebtAndEquitySecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debt_and_Equity_securities");
            entity.Property(e => e.DeferredTaxAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deferred_tax_assets");
            entity.Property(e => e.DepositsDueToOtherBanks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposits_due_to_other_banks");
            entity.Property(e => e.Dhabshil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dividend)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DividendPayment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dividend_payment");
            entity.Property(e => e.EfpcoService)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFPCO_service");
            entity.Property(e => e.EmbassiesAndOthers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Embassies_and_others");
            entity.Property(e => e.EmployeeBenefit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_Benefit");
            entity.Property(e => e.EmployeeBenefitsObligation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_benefits_obligation");
            entity.Property(e => e.EmployeeProvisions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_Provisions");
            entity.Property(e => e.EmployeeSalary)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_Salary");
            entity.Property(e => e.FinanceLeaseObligations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Finance_lease_obligations");
            entity.Property(e => e.GainOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gain_on_Fx");
            entity.Property(e => e.GarmentAndTextile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Garment_and_textile");
            entity.Property(e => e.GeneralExpenses)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("General_Expenses");
            entity.Property(e => e.GovernmentBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Government_bond");
            entity.Property(e => e.GovernmentDemand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Government_demand");
            entity.Property(e => e.GovernmentSaving)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Government_saving");
            entity.Property(e => e.GovernmentTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Government_time");
            entity.Property(e => e.GovernmentTotalDepositByOwnership)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Government_Total_deposit_by_ownership");
            entity.Property(e => e.ImpairmentOnFinancialAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Impairment_on_financial_assets");
            entity.Property(e => e.IntangibleAssetsSoftwares)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Intangible_assets__softwares");
            entity.Property(e => e.InterestExpense)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Interest_Expense");
            entity.Property(e => e.InvestmentInSubsidariesAndAssociates)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("investment_in_subsidaries_and_associates");
            entity.Property(e => e.LeatherAndLeatherProducts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Leather_and_leather_products");
            entity.Property(e => e.LegalReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("legal_reserve");
            entity.Property(e => e.LiquidityBuildUp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liquidity_build_up");
            entity.Property(e => e.LoansAdvancesAndFinancingCustomerNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_advances_and_financing_customer_net");
            entity.Property(e => e.LoansAndAdvancePrincipal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_and_advance_principal");
            entity.Property(e => e.LoansAndAdvances)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_and_Advances");
            entity.Property(e => e.LoansToFinancialInstitutions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_to_financial_institutions");
            entity.Property(e => e.LossOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loss_on_Fx");
            entity.Property(e => e.MarginHeldPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Margin_held_payable");
            entity.Property(e => e.MoneyGram)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Money_gram");
            entity.Property(e => e.NonCurrentAssetHeldForSaleNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Non_current_asset_held_for_sale_net");
            entity.Property(e => e.OilSeeds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oil_seeds");
            entity.Property(e => e.OtherAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_assets");
            entity.Property(e => e.OtherComprhensiveIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_comprhensive_income");
            entity.Property(e => e.OtherExports)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_exports");
            entity.Property(e => e.OtherIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Income");
            entity.Property(e => e.OtherLiablities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_liablities");
            entity.Property(e => e.OtherOfficialTransfers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_official_transfers");
            entity.Property(e => e.OtherPayableToNbe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_payable_to_NBE");
            entity.Property(e => e.OtherRemitance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_remitance");
            entity.Property(e => e.PosCashAdvance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POS_cash_advance");
            entity.Property(e => e.PrivateDemand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Private_demand");
            entity.Property(e => e.PrivateSaving)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Private_saving");
            entity.Property(e => e.PrivateSectorFcy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Private_sector_fcy");
            entity.Property(e => e.PrivateTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Private_time");
            entity.Property(e => e.PrivateTotalDepositByOwnership)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Private_Total_deposit_by_ownership");
            entity.Property(e => e.PrivateTransfers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("private_transfers");
            entity.Property(e => e.ProfitPaidToCbeNoorDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Profit_paid_to_cbe_noor_deposit");
            entity.Property(e => e.PropertyPlantAndEquipmentNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Property_plant_and_equipment_net");
            entity.Property(e => e.Provisions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("provisions");
            entity.Property(e => e.ProvsionalProfitLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Provsional_profit_loss");
            entity.Property(e => e.PublicEnterpriseDemand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Public_enterprise_demand");
            entity.Property(e => e.PublicEnterpriseSaving)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Public_enterprise_saving");
            entity.Property(e => e.PublicEnterpriseTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Public_enterprise_time");
            entity.Property(e => e.PublicEnterpriseTotalDepositByOwnership)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Public_enterprise_Total_deposit_by_ownership");
            entity.Property(e => e.PublicSectorFcy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("public_sector_fcy");
            entity.Property(e => e.Quarter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecievablesNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recievables_net");
            entity.Property(e => e.RegulatoryImpairmentReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Regulatory_impairment_reserve");
            entity.Property(e => e.RightOfUseAssetsNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Right_of_use_assets_net");
            entity.Property(e => e.Swift)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SWIFT");
            entity.Property(e => e.TaxAndPensionPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tax_and_pension_payable");
            entity.Property(e => e.TelecomService)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Telecom_service");
            entity.Property(e => e.TotalCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_collection");
            entity.Property(e => e.TotalDisbursment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_disbursment");
            entity.Property(e => e.Transfast)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferFromNbe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Transfer_from_NBE");
            entity.Property(e => e.UndpOfficialTransfers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNDP_official_transfers");
            entity.Property(e => e.UnicefOfficialTransfers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNICEF_official_transfers");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.WesternUnion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Western_union");
            entity.Property(e => e.WfpOfficialTransfers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WFP_official_transfers");
            entity.Property(e => e.WorldRemit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("World_remit");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sdbliquidity>(entity =>
        {
            entity.HasKey(e => e.IdNo).HasName("PK_Liquidity_risk");

            entity.ToTable("SDBLiquidity");

            entity.Property(e => e.IdNo).HasColumnName("ID_No");
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.AssetsMaturingWithinOneYear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_one_year");
            entity.Property(e => e.AssetsMaturingWithinSixMonths)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_six_months");
            entity.Property(e => e.AssetsMaturingWithinThreeMonths)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_three_months");
            entity.Property(e => e.AssetsMaturingWithinThreeMonthsCashAndBalanceWithNbe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_three_months_cash_and_balance_with_NBE");
            entity.Property(e => e.AssetsMaturingWithinThreeMonthsDebitAndEquitySecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_three_months_debit_and_equity_securities");
            entity.Property(e => e.AssetsMaturingWithinThreeMonthsLoanAndAdvanceToCustomers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_three_months_loan_and_advance_to_customers");
            entity.Property(e => e.AssetsMaturingWithinThreeMonthsLoanAndFinancialInstitutions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assets_maturing_within_three_months_loan_and_financial_institutions");
            entity.Property(e => e.BondInterestCashCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Bond_interest_cash_collection");
            entity.Property(e => e.BondPrincipalCashCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Bond_principal_cash_collection");
            entity.Property(e => e.Borrowing)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cooperative)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customer_Deposit");
            entity.Property(e => e.DemandDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Demand_Deposit");
            entity.Property(e => e.DisbursementCouponAndCorporateBonds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Disbursement_Coupon_and_Corporate_Bonds");
            entity.Property(e => e.DisbursementLoansAndAdv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Disbursement_Loans_and_Adv");
            entity.Property(e => e.Government)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hqla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HQLA");
            entity.Property(e => e.IfbDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IFB_Deposit");
            entity.Property(e => e.IncreaseInDepositOrNetOfReserveReqmtAndNonFundInflows)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Increase_in_Deposit_Or_net_of_reserve_reqmt_and_non_fund_inflows");
            entity.Property(e => e.Individual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterestCashCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Interest_cash_collection");
            entity.Property(e => e.LiabilitiesMaturingWithinThreeMonthCustomersDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liabilities_maturing_within_Three_month_Customers_Deposit");
            entity.Property(e => e.LiabilitiesMaturingWithinThreeMonthDepositDueToOtherBanks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liabilities_maturing_within_Three_month_Deposit_Due_to_other_banks");
            entity.Property(e => e.LiabilitiesMaturingWithinThreeMonthOtherLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liabilities_maturing_within_Three_month_Other_Liabilities");
            entity.Property(e => e.LiablityMaturingWithinOneYear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liablity_maturing_within_one_year");
            entity.Property(e => e.LiablityMaturingWithinSixMonths)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liablity_maturing_within_six_months");
            entity.Property(e => e.LiablityMaturingWithinThreeMonths)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Liablity_maturing_within_three_months");
            entity.Property(e => e.LoanInterestCashCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loan_interest_cash_collection");
            entity.Property(e => e.LoanPrincipalCashCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loan_principal_cash_collection");
            entity.Property(e => e.OtherLiablity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_liablity");
            entity.Property(e => e.PrincipalCashCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Principal_cash_collection");
            entity.Property(e => e.PrincipalCollectionCoupAndCorpBonds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Principal_Collection_Coup_and_Corp_Bonds");
            entity.Property(e => e.PrincipalCollectionLoansAndAdvances)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Principal_Collection_Loans_and_Advances");
            entity.Property(e => e.Private)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProvisionalProfitPerLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Provisional_profit_per_loss");
            entity.Property(e => e.Publice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quarter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SavingDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Saving_Deposit");
            entity.Property(e => e.TimeDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Time_Deposit");
            entity.Property(e => e.Top1000Depositors)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_1000_Depositors");
            entity.Property(e => e.Top100Depositors)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_100_Depositors");
            entity.Property(e => e.Top10Depositors)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_10_Depositors");
            entity.Property(e => e.TotalAsset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_asset");
            entity.Property(e => e.TotalCapital)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_Capital");
            entity.Property(e => e.TotalLiability)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_liability");
            entity.Property(e => e.TotalLiquidAsset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_liquid_asset");
            entity.Property(e => e.TotalNetCurrentLiablity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_net_current_liablity");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SebactualFinancialStatement>(entity =>
        {
            entity.ToTable("SEBActual_financial_statement");

            entity.Property(e => e.AccumulatedProfitOrLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Accumulated_profit_or_loss");
            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.BondsAndSecuritiesInterestIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BONDS_and_SECURITIES_Interest_Income");
            entity.Property(e => e.BorrowingNationalBankLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Borrowing_National_Bank_Liabilities");
            entity.Property(e => e.Capital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CashAndCashEquivalent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cash_and_cash_equivalent");
            entity.Property(e => e.CbeNoorIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBE_NOOR_INCOME");
            entity.Property(e => e.CbeNoorReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBE_Noor_reserve");
            entity.Property(e => e.CommissionAndChargesIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMISSION_AND_CHARGES_Income");
            entity.Property(e => e.CustomersDeposits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customers_deposits");
            entity.Property(e => e.DebtAndEquitySecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debt_and_Equity_securities");
            entity.Property(e => e.DeferredTaxAsset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deferred_tax_asset");
            entity.Property(e => e.DepositsDueToOtherBanks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposits_Due_to_Other_Banks");
            entity.Property(e => e.Dividend)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeBenefitsObligation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_Benefits_Obligation");
            entity.Property(e => e.EmployeesBenefits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEES_BENEFITS");
            entity.Property(e => e.EmployeesProvisions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEES_PROVISIONS");
            entity.Property(e => e.EmployeesSalaries)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEES_SALARIES");
            entity.Property(e => e.FinanceLeaseObligations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Finance_lease_obligations");
            entity.Property(e => e.GainOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gain_On_FX");
            entity.Property(e => e.GeneralExpenses)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENERAL_EXPENSES");
            entity.Property(e => e.ImpairmentOnFinancialAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPAIRMENT_ON_FINANCIAL_ASSETS");
            entity.Property(e => e.IntangibleAssetsSoftwares)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Intangible_Assets_Softwares");
            entity.Property(e => e.InterestExpense)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTEREST_EXPENSE");
            entity.Property(e => e.InvestmentsInSubsidiariesAndAssociates)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Investments_in_subsidiaries_and_associates");
            entity.Property(e => e.LegalReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Legal_reserve");
            entity.Property(e => e.LoansAdvancesAndFinancingToCustomersNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_advances_and_Financing_to_customers_net");
            entity.Property(e => e.LoansAndAdvancesInterestIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOANS_AND_ADVANCES_Interest_Income");
            entity.Property(e => e.LoansToFinancialInstitutions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loans_to_Financial_institutions");
            entity.Property(e => e.LossOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOSS_ON_FX");
            entity.Property(e => e.MarginHeldPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Margin_Held_Payable");
            entity.Property(e => e.NonCurrentAssetsHeldForSaleNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Non_current_assets_held_for_sale_net");
            entity.Property(e => e.OffBalanceSheetbidBondsPerformanceBonds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BALANCE_SHEETBid_bonds_Performance_Bonds");
            entity.Property(e => e.OffBalanceSheetletterOfCredit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BALANCE_SHEETLetter_of_credit");
            entity.Property(e => e.OffBalanceSheetloansAndBondCom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BALANCE_SHEETLoans_and_Bond_Com");
            entity.Property(e => e.OffBalanceSheetloansAndBondComGuarantedByCentralGov)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BALANCE_SHEETLoans_and_Bond_Com_guaranted_by_central_gov");
            entity.Property(e => e.OffBalanceSheetloansComGuarnateedByRegionalGov)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BALANCE_SHEETLoans_com_Guarnateed_by_regional_gov");
            entity.Property(e => e.OffBalanceSheetoffBalanceSheet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BALANCE_SHEETOFF_BALANCE_SHEET");
            entity.Property(e => e.OtherAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Assets");
            entity.Property(e => e.OtherComprehensiveIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Comprehensive_income");
            entity.Property(e => e.OtherIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTHER_INCOME");
            entity.Property(e => e.OtherLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Other_Liabilities");
            entity.Property(e => e.ProfitLossBeforeTaxation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROFIT_LOSS_BEFORE_TAXATION");
            entity.Property(e => e.ProfitPaidToCbeNoorDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROFIT_PAID_TO_CBE_NOOR_DEPOSIT");
            entity.Property(e => e.PropertyPlantAndEquipmentNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Property_plant_and_equipment_net");
            entity.Property(e => e.ProvisionalProfitLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Provisional_profit_loss");
            entity.Property(e => e.Provisions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReceivablesNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Receivables_net");
            entity.Property(e => e.RegulatoryImpairmentReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Regulatory_Impairment_reserve");
            entity.Property(e => e.RightOfUseAssetsNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Right_of_use_assets_Net");
            entity.Property(e => e.TaxAndPensionPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tax_and_Pension_Payable");
            entity.Property(e => e.TotalIncomeCbeNoorFinancing)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOTAL_INCOME_CBE_NOOR_FINANCING");
            entity.Property(e => e.TotalInterestEarnedLoansAndAdva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOTAL_INTEREST_EARNED_LOANS_AND_ADVA");
            entity.Property(e => e.TotalOffBsCommit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_off_Bs_commit");
            entity.Property(e => e.TotalRiskWeightedAssetRwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_Risk_Weighted_Asset_RWA");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SebcreditRisk>(entity =>
        {
            entity.ToTable("SEBCredit_risk");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.Csbl)
                .HasMaxLength(50)
                .HasColumnName("CSBL");
            entity.Property(e => e.DisbursementCouponAndCorporateBonds)
                .HasMaxLength(50)
                .HasColumnName("Disbursement_Coupon_And_Corporate_Bonds");
            entity.Property(e => e.DisbursementLoansAndAdv)
                .HasMaxLength(50)
                .HasColumnName("Disbursement_Loans_And_Adv");
            entity.Property(e => e.LoanAndAdavce)
                .HasMaxLength(50)
                .HasColumnName("Loan_and_Adavce");
            entity.Property(e => e.NcsblPrivateAndCooperatives)
                .HasMaxLength(50)
                .HasColumnName("NCSBL_Private_and_Cooperatives");
            entity.Property(e => e.NetCoupon)
                .HasMaxLength(50)
                .HasColumnName("Net_Coupon");
            entity.Property(e => e.NetLoan)
                .HasMaxLength(50)
                .HasColumnName("Net_Loan");
            entity.Property(e => e.NonPerformingLoanNpl)
                .HasMaxLength(50)
                .HasColumnName("Non_Performing_Loan_NPL");
            entity.Property(e => e.PerformingLoanAmount)
                .HasMaxLength(50)
                .HasColumnName("Performing_loan_amount");
            entity.Property(e => e.PrincipalCollectionCoupAndCorpBonds)
                .HasMaxLength(50)
                .HasColumnName("Principal_Collection_Coup_And_Corp_Bonds");
            entity.Property(e => e.PrincipalCollectionLoansAndAdvances)
                .HasMaxLength(50)
                .HasColumnName("Principal_Collection_Loans_And_Advances");
            entity.Property(e => e.Provision).HasMaxLength(50);
            entity.Property(e => e.TotalBond)
                .HasMaxLength(50)
                .HasColumnName("Total_Bond");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<SebforcastedFinancialStatement>(entity =>
        {
            entity.ToTable("SEBForcasted_Financial_Statement");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.ForcastedAccruedInterestOnCouponBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Accrued_Interest_on_Coupon_Bond");
            entity.Property(e => e.ForcastedAccruedInterestOnDbesBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Accrued_Interest_on_DBEs_Bond");
            entity.Property(e => e.ForcastedAccruedInterestOnLoansAndAdvance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Accrued_Interest_on_Loans_and_Advance");
            entity.Property(e => e.ForcastedAccumulatedProfitOrLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Accumulated_profit_or_loss");
            entity.Property(e => e.ForcastedBorrowingNationalBankLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Borrowing_National_Bank_Liabilities");
            entity.Property(e => e.ForcastedCapital)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Capital");
            entity.Property(e => e.ForcastedCashAndCashEquivalent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Cash_and_cash_equivalent");
            entity.Property(e => e.ForcastedCbeNoorDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_CBE_Noor_Deposit");
            entity.Property(e => e.ForcastedCbeNoorIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_CBE_NOOR_INCOME");
            entity.Property(e => e.ForcastedCbeNoorReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_CBE_Noor_reserve");
            entity.Property(e => e.ForcastedCommissionAndCharges)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_COMMISSION_AND_CHARGES");
            entity.Property(e => e.ForcastedCouponBondPrincipal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Coupon_Bond_Principal");
            entity.Property(e => e.ForcastedCustomersDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Customers_deposit");
            entity.Property(e => e.ForcastedDbeBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_DBE_Bond");
            entity.Property(e => e.ForcastedDebtAndEquitySecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Debt_and_Equity_securities");
            entity.Property(e => e.ForcastedDeferredTaxAsset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Deferred_tax_asset");
            entity.Property(e => e.ForcastedDemandDepositAssociations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Demand_Deposit_ASSOCIATIONS");
            entity.Property(e => e.ForcastedDemandDepositGovernment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Demand_Deposit_GOVERNMENT");
            entity.Property(e => e.ForcastedDemandDepositPrivate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Demand_Deposit_PRIVATE");
            entity.Property(e => e.ForcastedDemandDepositPublicEnterprises)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Demand_Deposit_PUBLIC_ENTERPRISES");
            entity.Property(e => e.ForcastedDepositsDueToOtherBanks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Deposits_Due_to_Other_Banks");
            entity.Property(e => e.ForcastedDividend)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Dividend");
            entity.Property(e => e.ForcastedEmployeeBenefitsObligation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Employee_Benefits_Obligation");
            entity.Property(e => e.ForcastedEmployeesBenefits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_EMPLOYEES_BENEFITS");
            entity.Property(e => e.ForcastedEmployeesProvisions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_EMPLOYEES_PROVISIONS");
            entity.Property(e => e.ForcastedEmployeesSalaries)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_EMPLOYEES_SALARIES");
            entity.Property(e => e.ForcastedFinanceLeaseObligations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Finance_lease_obligations");
            entity.Property(e => e.ForcastedGainOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Gain_On_FX");
            entity.Property(e => e.ForcastedGeneralExpenses)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_GENERAL_EXPENSES");
            entity.Property(e => e.ForcastedGovernmentBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Government_Bond");
            entity.Property(e => e.ForcastedImpairmentOnFinancialAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_IMPAIRMENT_ON_FINANCIAL_ASSETS");
            entity.Property(e => e.ForcastedIntangibleAssetsSoftwares)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Intangible_Assets_Softwares");
            entity.Property(e => e.ForcastedInterestExpense)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_INTEREST_EXPENSE");
            entity.Property(e => e.ForcastedInterestIncomeLoansAndAdvances)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_INTEREST_INCOME_LOANS_AND_ADVANCES");
            entity.Property(e => e.ForcastedInterestIncomebondsAndSecurities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_INTEREST_INCOMEBONDS_and_SECURITIES");
            entity.Property(e => e.ForcastedInvestmentsInSubsidiariesAndAssociates)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Investments_in_subsidiaries_and_associates");
            entity.Property(e => e.ForcastedLegalReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Legal_reserve");
            entity.Property(e => e.ForcastedLoansAdvancesAndFinancingToCustomersNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Loans_advances_and_Financing_to_customers_net");
            entity.Property(e => e.ForcastedLoansAndAndAdvancePrincipal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Loans_and_and_Advance_Principal");
            entity.Property(e => e.ForcastedLoansToFinancialInstitutions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Loans_to_Financial_institutions");
            entity.Property(e => e.ForcastedLossOnFx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_LOSS_ON_FX");
            entity.Property(e => e.ForcastedMarginHeldPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Margin_Held_Payable");
            entity.Property(e => e.ForcastedNonCurrentAssetsHeldForSaleNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Non_current_assets_held_for_sale_net");
            entity.Property(e => e.ForcastedOtherAssets)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Other_Assets");
            entity.Property(e => e.ForcastedOtherComprehensiveIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Other_Comprehensive_income");
            entity.Property(e => e.ForcastedOtherIncome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_OTHER_INCOME");
            entity.Property(e => e.ForcastedOtherLiabilities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Other_Liabilities");
            entity.Property(e => e.ForcastedProfitLossBeforeTaxation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_PROFIT_LOSS_BEFORE_TAXATION");
            entity.Property(e => e.ForcastedProfitPaidToCbeNoorDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_PROFIT_PAID_TO_CBE_NOOR_DEPOSIT");
            entity.Property(e => e.ForcastedPropertyPlantAndEquipmentNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Property_plant_and_equipment_net");
            entity.Property(e => e.ForcastedProvisionalProfitLoss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Provisional_profit_loss");
            entity.Property(e => e.ForcastedProvisions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Provisions");
            entity.Property(e => e.ForcastedReceivablesNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Receivables_net");
            entity.Property(e => e.ForcastedRegulatoryImpairmentReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Regulatory_Impairment_reserve");
            entity.Property(e => e.ForcastedRightOfUseAssetsNet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Right_of_use_assets_Net");
            entity.Property(e => e.ForcastedSavingAssociations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Saving_ASSOCIATIONS");
            entity.Property(e => e.ForcastedSavingGovernment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Saving_GOVERNMENT");
            entity.Property(e => e.ForcastedSavingPrivate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Saving_PRIVATE");
            entity.Property(e => e.ForcastedSavingPublicEnterprises)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Saving_PUBLIC_ENTERPRISES");
            entity.Property(e => e.ForcastedTaxAndPensionPayable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Tax_and_Pension_Payable");
            entity.Property(e => e.ForcastedTimeAssociations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Time_ASSOCIATIONS");
            entity.Property(e => e.ForcastedTimeGovernment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Time_GOVERNMENT");
            entity.Property(e => e.ForcastedTimePrivate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Time_PRIVATE");
            entity.Property(e => e.ForcastedTimePublicEnterprises)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Time_PUBLIC_ENTERPRISES");
            entity.Property(e => e.ForcastedYear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Forcasted_Year");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
        });

        modelBuilder.Entity<SebliquidityRisk>(entity =>
        {
            entity.ToTable("SEBLiquidity_Risk");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.OutstandingDeposit)
                .HasMaxLength(50)
                .HasColumnName("Outstanding_Deposit");
            entity.Property(e => e.TotalCbeNoorDemandDeposit)
                .HasMaxLength(50)
                .HasColumnName("Total_CBE_Noor_Demand_Deposit");
            entity.Property(e => e.TotalCbeNoorFixedDeposit)
                .HasMaxLength(50)
                .HasColumnName("Total_CBE_Noor_Fixed_Deposit");
            entity.Property(e => e.TotalCbeNoorSavingDeposit)
                .HasMaxLength(50)
                .HasColumnName("Total_CBE_Noor_Saving_Deposit");
            entity.Property(e => e.TotalDemandDeposit)
                .HasMaxLength(50)
                .HasColumnName("Total_Demand_Deposit");
            entity.Property(e => e.TotalFixedDeposit)
                .HasMaxLength(50)
                .HasColumnName("Total_Fixed_Deposit");
            entity.Property(e => e.TotalSavingsDeposit)
                .HasMaxLength(50)
                .HasColumnName("Total_Savings_Deposit");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<Sebmacroeconomic>(entity =>
        {
            entity.ToTable("SEBMacroeconomics");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.AverageAnnualExchageRate)
                .HasMaxLength(50)
                .HasColumnName("Average_Annual_Exchage_rate");
            entity.Property(e => e.BroadMoneySupply)
                .HasMaxLength(50)
                .HasColumnName("Broad_Money_Supply");
            entity.Property(e => e.BudgetDeficit)
                .HasMaxLength(50)
                .HasColumnName("Budget_Deficit");
            entity.Property(e => e.CurrencyOutsideTheBank)
                .HasMaxLength(50)
                .HasColumnName("Currency_Outside_the_bank");
            entity.Property(e => e.CurrentAccountBalance)
                .HasMaxLength(50)
                .HasColumnName("Current_Account_Balance");
            entity.Property(e => e.Export).HasMaxLength(50);
            entity.Property(e => e.GovernmentExpenditure)
                .HasMaxLength(50)
                .HasColumnName("Government_Expenditure");
            entity.Property(e => e.Import).HasMaxLength(50);
            entity.Property(e => e.Inflation).HasMaxLength(50);
            entity.Property(e => e.RealGdp)
                .HasMaxLength(50)
                .HasColumnName("Real_GDP");
            entity.Property(e => e.TradeBalance)
                .HasMaxLength(50)
                .HasColumnName("Trade_Balance");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<SebmarketRisk>(entity =>
        {
            entity.ToTable("SEBMarket_Risk");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.NetFxPositionMillionUsd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Net_FX_position_Million_USD");
            entity.Property(e => e.OffBalanceSheetFxPosition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Off_balance_sheet_FX_position");
            entity.Property(e => e.OffBsAsset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BS_Asset");
            entity.Property(e => e.OffBsLiablities)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFF_BS_Liablities");
            entity.Property(e => e.OnBsAssetsInOtherCurrenciesInBirr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("On_BS_Assets_in_other_currencies_in_birr");
            entity.Property(e => e.OnBsAssetsInUsd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("On_BS_Assets_in_USD");
            entity.Property(e => e.OnBsAssetsUsdEquivalent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("On_BS_Assets_USD_equivalent");
            entity.Property(e => e.OnBsLiabilitiesUsdEquivalent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("On_BS_Liabilities_USD_equivalent");
            entity.Property(e => e.OnBsLiablitiesInOtherCurrenciesInBirr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("On_BS_Liablities_in_other_currencies_in_birr");
            entity.Property(e => e.OnBsLiablitiesInUsd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("On_BS_Liablities_in_USD");
            entity.Property(e => e.OpenPositionOtherCurrencyShort)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Open_Position_Other_currency_short");
            entity.Property(e => e.OpenPositionUsdShort)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Open_Position_USD_short");
            entity.Property(e => e.TotalOnBsFcyAssetsOtherCurrencies)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_On_BS_FCY_Assets_Other_currencies");
            entity.Property(e => e.TotalOnBsFcyAssetsUsd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_On_BS_FCY_Assets_USD");
            entity.Property(e => e.TotalOnBsFcyLiabilityOtherCurrencies)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_On_BS_FCY_Liability_Other_currencies");
            entity.Property(e => e.TotalOnBsFcyLiabilityUsd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_On_BS_FCY_Liability_USD");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Severity>(entity =>
        {
            entity.ToTable("Severity");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Severities)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Severity_UserProfile");
        });

        modelBuilder.Entity<SeverityForAnalysis>(entity =>
        {
            entity.ToTable("SeverityForAnalysis");

            entity.Property(e => e.ActualLossPerNearMissLossToAverageOfTheThreeYearsGrossIncomeRatio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Actual_loss_per_near_miss_loss_to_average_of_the_three_years_gross_income_ratio");
            entity.Property(e => e.CreditConversionFactorForGuarantee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Credit_conversion_factor_for_Guarantee");
            entity.Property(e => e.CreditConversionFactorForLc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Credit_conversion_factor_for_LC");
            entity.Property(e => e.DepositGrowthPerDrawdown)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposit_Growth_per_Drawdown");
            entity.Property(e => e.DepositInterestRateForSaving)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposit_Interest_rate_for_Saving");
            entity.Property(e => e.DepositInterestRateForTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposit_Interest_rate_for_Time");
            entity.Property(e => e.DepositMaturingInTheNextThreeMonths)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deposit_maturing_in_the_next_three_months");
            entity.Property(e => e.DevaluationOfBirrToUsdShareOfTheGapBnOfficialAndParallel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Devaluation_of_Birr_to_USD_Share_of_the_gap_bn_official_and_Parallel");
            entity.Property(e => e.DisburcementShareOfBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Disburcement_Share_of_Bond");
            entity.Property(e => e.DisburcementShareOfLoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Disburcement_Share_of_Loan");
            entity.Property(e => e.EffectiveInterestRateOfBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Effective_Interest_Rate_of_Bond");
            entity.Property(e => e.EffectiveInterestRateOfLoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Effective_Interest_Rate_of_Loan");
            entity.Property(e => e.External)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("External_");
            entity.Property(e => e.IncrementalConventionalDepositShare)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Incremental_Conventional_Deposit_Share");
            entity.Property(e => e.IncrementalConventionalSavingDepositShare)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Incremental_Conventional_Saving_Deposit_Share");
            entity.Property(e => e.IncrementalConventionalTimeDepositShare)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Incremental_Conventional_Time_Deposit_Share");
            entity.Property(e => e.IncrementalDepositNetOfNonFundImpact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Incremental_deposit_net_of_non_fund_Impact");
            entity.Property(e => e.IncrementalIfbDepositShare)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Incremental_IFB_Deposit_Share");
            entity.Property(e => e.InterestCollectionFromTotalCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Interest_collection_from_total_collection");
            entity.Property(e => e.InterestRateDecrease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Interest_Rate_Decrease");
            entity.Property(e => e.InterestRateForLongTermLAndA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Interest_Rate_for_long_term_L_and_A");
            entity.Property(e => e.InterestRateIncrease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Interest_Rate_Increase");
            entity.Property(e => e.LegalReserve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Legal_Reserve");
            entity.Property(e => e.MaximumFundApplicationRate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Maximum_Fund_Application_Rate");
            entity.Property(e => e.MidRateGrowthUsdToBirr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Mid_Rate_Growth_USD_to_Birr");
            entity.Property(e => e.NplGrowth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPL_Growth");
            entity.Property(e => e.NplShare)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPL_share");
            entity.Property(e => e.People)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrincipalCollectionFromTotalCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Principal_collection_from_total_collection");
            entity.Property(e => e.PrincipalCollectionShareOfBond)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Principal_Collection_share_of_bond");
            entity.Property(e => e.PrincipalCollectionShareOfLoanAndAdvance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Principal_Collection_share_of_Loan_and_Advance");
            entity.Property(e => e.Process)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quarter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatioOfPrincipalLoanCollectionToPrincipalLoansAndAdvancesAmount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ratio_of_Principal_loan_collection_to_principal_Loans_and_Advances_Amount");
            entity.Property(e => e.ScheduledPayables)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Scheduled_Payables");
            entity.Property(e => e.ShareOfFreshBondDisbursmentFromTheTotalDisbursment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Share_of_fresh_bond_disbursment_from_the_total_disbursment");
            entity.Property(e => e.ShareOfNcsbcFromTheTotalLoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Share_of_NCSBC_from_the_total_loan");
            entity.Property(e => e.ShareOfNewLoanDisbursmentFromTheTotalDisbursment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Share_of_new_loan_disbursment_from_the_total_disbursment");
            entity.Property(e => e.ShareOfPrincipalBondCollectionToPrincipalBondAmount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Share_of_Principal_bond_collection_to_principal_bond_Amount");
            entity.Property(e => e.System)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TheIncrementOnTheActualMidRateImpactedByTheAverageGrowthRateAndDevaluation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("The_increment_on_the_actual_mid_rate_impacted_by_the_average_growth_rate_and_devaluation");
            entity.Property(e => e.TheShareOfFcyBsByCuurenyTypeUsd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("The_share_of_FCY_BS_by_Cuureny_Type_USD");
            entity.Property(e => e.Top1000DepositorsShareFromTotalDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_1000_Depositors_Share_from_Total_Deposit");
            entity.Property(e => e.Top1000DepositorsWithdraw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_1000_Depositors_withdraw");
            entity.Property(e => e.Top100DepositorsShareFromTotalDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_100_Depositors_Share_from_Total_Deposit");
            entity.Property(e => e.Top100DepositorsWithdraw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_100_Depositors_withdraw");
            entity.Property(e => e.Top10DepositorsShareFromTotalDeposit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_10_Depositors_Share_from_Total_Deposit");
            entity.Property(e => e.Top10DepositorsWithdraw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Top_10_Depositors_withdraw");
            entity.Property(e => e.TotalNetCurrentLiability)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_Net_Current_Liability");
            entity.Property(e => e.UnplannedMaterializationOfCommitmentsAdjusted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Unplanned_Materialization_of_Commitments_Adjusted");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UploadedDate).HasColumnType("datetime");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SeverityCat).WithMany(p => p.SeverityForAnalyses)
                .HasForeignKey(d => d.SeverityCatId)
                .HasConstraintName("FK_SeverityForAnalysis_SeverityForAnalysis");

            entity.HasOne(d => d.UploaderUser).WithMany(p => p.SeverityForAnalyses)
                .HasForeignKey(d => d.UploaderUserId)
                .HasConstraintName("FK_SeverityForAnalysis_UserProfile");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.ToTable("UserProfile");

            entity.Property(e => e.EmployeeId).HasMaxLength(150);
            entity.Property(e => e.UserEmail).HasMaxLength(150);

            entity.HasOne(d => d.UserRole).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UserRoleId)
                .HasConstraintName("FK_UserProfile_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
