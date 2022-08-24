using System;
using System.Text.Json.Serialization;
using ApiDataStreamToSqlDb.JsonConverters;

#nullable enable
namespace ApiDataStreamToSqlDb.Dtos
{
    public class OpenDataPortalPropertyDto
    {
        [JsonPropertyName("account_id_mdp_field_acctid")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? AccountId { get; set; }

        [JsonPropertyName("jurisdiction_code_mdp_field_jurscode")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? JurisdictionCode { get; set; }

        [JsonPropertyName("county_name_mdp_field_cntyname")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? CountyName { get; set; }

        [JsonPropertyName("mdp_longitude_mdp_field_digxcord_converted_to_wgs84")]
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double Longitude { get; set; }

        [JsonPropertyName("mdp_latitude_mdp_field_digycord_converted_to_wgs84")]
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double Latitude { get; set; }

        [JsonPropertyName("record_key_county_code_sdat_field_1")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? CountyCode { get; set; }

        [JsonPropertyName("record_key_district_ward_sdat_field_2")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? DistrictWard { get; set; }

        [JsonPropertyName("record_key_account_number_sdat_field_3")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? AccountNumber { get; set; }

        [JsonPropertyName("record_key_geographic_code_mdp_field_geogcode_sdat_field_5")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? GeographicCode { get; set; }

        [JsonPropertyName("record_key_owner_occupancy_code_mdp_field_ooi_sdat_field_6")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? OwnerOccupancyCode { get; set; }

        [JsonPropertyName("record_key_owner_s_name_mdp_field_ownname1_sdat_field_7")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? Owner1FullName { get; set; }

        [JsonPropertyName("record_key_name_key_mdp_field_namekey_sdat_field_9")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? NameKey { get; set; }

        [JsonPropertyName("owner_mailing_address_address_1st_line_mdp_field_ownadd1_sdat_field_10")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? OwnerStreet { get; set; }

        [JsonPropertyName("owner_mailing_address_city_mdp_field_owncity_sdat_field_12")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? OwnerCity { get; set; }

        [JsonPropertyName("owner_mailing_address_state_code_mdp_field_ownstate_sdat_field_13")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? OwnerState { get; set; }

        [JsonPropertyName("owner_mailing_address_zip_code_mdp_field_ownerzip_sdat_field_14")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? OwnerZipCode { get; set; }

        [JsonPropertyName("owner_mailing_address_zip_4_code_mdp_field_ownzip2_sdat_field_15")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? OwnerZipCodeExtension { get; set; }

        [JsonPropertyName("legal_description_line_1_mdp_field_legal1_sdat_field_17")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? LegalDescriptionLine1 { get; set; }

        [JsonPropertyName("legal_description_line_2_mdp_field_legal2_sdat_field_18")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? LegalDescriptionLine2 { get; set; }

        [JsonPropertyName("legal_description_line_3_mdp_field_legal3_sdat_field_19")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? LegalDescriptionLine3 { get; set; }

        [JsonPropertyName("mdproperty_view_edition_year_mdp_field_existing")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? ViewEditionYear { get; set; }

        [JsonPropertyName("mdp_street_address_mdp_field_address")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? MDPStreet { get; set; }

        [JsonPropertyName("mdp_street_address_city_mdp_field_city")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? MDPCity { get; set; }

        [JsonPropertyName("mdp_street_address_zip_code_mdp_field_zipcode")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? MDPZipCode { get; set; }

        [JsonPropertyName("premise_address_number_mdp_field_premsnum_sdat_field_20")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressNumber { get; set; }

        [JsonPropertyName("premise_address_direction_mdp_field_premsdir_sdat_field_22")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressDirection { get; set; }

        [JsonPropertyName("premise_address_name_mdp_field_premsnam_sdat_field_23")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressName { get; set; }

        [JsonPropertyName("premise_address_type_mdp_field_premstyp_sdat_field_24")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressType { get; set; }

        [JsonPropertyName("premise_address_city_mdp_field_premcity_sdat_field_25")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressCity { get; set; }

        [JsonPropertyName("premise_address_zip_code_mdp_field_premzip_sdat_field_26")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressZipCode { get; set; }

        [JsonPropertyName("premise_address_zip_4_code_mdp_field_premzip2_sdat_field_27")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? PremiseAddressZipCodeExtension { get; set; }

        [JsonPropertyName("deed_reference_1_clerk_setials_mdp_field_dr1clerk_sdat_field_29")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? DeedReference1ClerkInitials { get; set; }

        [JsonPropertyName("deed_reference_1_liber_mdp_field_dr1liber_sdat_field_30")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? DeedReference1Liber { get; set; }

        [JsonPropertyName("deed_reference_1_folio_mdp_field_dr1folio_sdat_field_31")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? DeedReference1Folio { get; set; }

        [JsonPropertyName("town_code_mdp_field_towncode_desctown_sdat_field_36")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? TownCode { get; set; }

        [JsonPropertyName("subdivision_code_mdp_field_subdivsn_sdat_field_37")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? SubdivisionCode { get; set; }

        [JsonPropertyName("lot_mdp_field_lot_sdat_field_41")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? Lot { get; set; }

        [JsonPropertyName("map_mdp_field_map_sdat_field_42")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? Map { get; set; }

        [JsonPropertyName("grid_mdp_field_grid_sdat_field_43")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? Grid { get; set; }

        [JsonPropertyName("parcel_mdp_field_parcel_sdat_field_44")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? Parcel { get; set; }

        [JsonPropertyName("zoning_code_mdp_field_zoning_sdat_field_45")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? ZoningCode { get; set; }

        [JsonPropertyName("exempt_class_mdp_field_exclass_descexcl_sdat_field_49")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? ExemptClass { get; set; }

        [JsonPropertyName("mdp_street_address_type_code_mdp_field_resityp")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? MDPStreetAddressTypeCode { get; set; }

        [JsonPropertyName("land_use_code_mdp_field_lu_desclu_sdat_field_50")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? LandUseCode { get; set; }

        [JsonPropertyName("multi_parent_account_ind_sdat_field_55")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? MultiParentAccount { get; set; }

        [JsonPropertyName("tax_class_sdat_field_58")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? TaxClass { get; set; }

        [JsonPropertyName("recreational_influence_ind_mdp_field_recind_sdat_field_60")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? RecreationalInfluence { get; set; }

        [JsonPropertyName("bpruc_public_use_code_mdp_field_ciuse_descciuse_sdat_field_61")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? BureauOfPublicRoadsUseCode { get; set; }

        [JsonPropertyName("ad_valorem_code_sdat_field_62")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? AdValoremCode { get; set; }

        [JsonPropertyName("property_factors_utilities_water_mdp_field_pfuw_sdat_field_63")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? PropertyFactorsUtilitiesWater { get; set; }

        [JsonPropertyName("property_factors_utilities_sewer_mdp_field_pfus_sdat_field_64")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? PropertyFactorsUtilitiesSewer { get; set; }

        [JsonPropertyName("property_factors_location_waterfront_mdp_field_pflw_sdat_field_65")]
        [JsonConverter(typeof(StringWithBlankNone0Blank0NulledJsonConverter))]
        public string? PropertyFactorsLocationWaterfront { get; set; }

        [JsonPropertyName("property_factors_street_paved_mdp_field_pfsp_sdat_field_67")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? PropertyFactorsStreetPaved { get; set; }

        [JsonPropertyName("property_factors_street_unpaved_mdp_field_pfsu_sdat_field_68")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? PropertyFactorsStreetUnpaved { get; set; }

        [JsonPropertyName("property_factors_influence_commer_indust_mdp_field_pfic_sdat_field_69")]
        [JsonConverter(typeof(StringWithBlankNone0Blank0NulledJsonConverter))]
        public string? PropertyFactorsInfluenceCommercialIndustrial { get; set; }

        [JsonPropertyName("property_factors_influence_historical_mdp_field_pfih_sdat_field_70")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? PropertyFactorsInfluenceHistorical { get; set; }

        [JsonPropertyName("field_card_number_field_card_no_primary_mdp_field_fcrd1st5_sdat_field_75")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? FieldCardNumberPrimary { get; set; }

        [JsonPropertyName("field_card_number_field_card_no_secondary_mdp_field_fcrdnxt3_sdat_field_76")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? FieldCardNumberSecondary { get; set; }

        [JsonPropertyName("field_card_number_field_card_no_subset_3_mdp_field_fcrdnxt2_sdat_field_77")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? FieldCardNumberSubset3 { get; set; }

        [JsonPropertyName("field_card_number_field_card_no_subset_4_mdp_field_fcrdlst2_sdat_field_78")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? FieldCardNumberSubset4 { get; set; }

        [JsonPropertyName("sales_segment_1_transfer_number_mdp_field_transno1_sdat_field_79")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment1TransferNumber { get; set; }

        [JsonPropertyName("sales_segment_1_grantor_name_mdp_field_grntnam1_sdat_field_80")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? SalesSegment1GrantorFullName { get; set; }

        [JsonPropertyName("sales_segment_1_grantor_deed_reference_1_liber_mdp_field_gr1libr1_sdat_field_82")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment1GrantorDeedReferenceLiber { get; set; }

        [JsonPropertyName("sales_segment_1_grantor_deed_reference_1_folio_mdp_field_gr1folo1_sdat_field_83")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment1GrantorDeedReferenceFolio { get; set; }

        [JsonPropertyName("sales_segment_1_how_conveyed_ind_mdp_field_convey1_sdat_field_87")]
        [JsonConverter(typeof(StringWithNoDataNulledJsonConverter))]
        public string? SalesSegment1HowConveyed { get; set; }

        [JsonPropertyName("sales_segment_1_transfer_date_yyyy_mm_dd_mdp_field_tradate_sdat_field_89")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SalesSegment1TransferDate { get; set; }

        [JsonPropertyName("sales_segment_1_consideration_mdp_field_considr1_sdat_field_90")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment1Consideration { get; set; }

        [JsonPropertyName("sales_segment_1_mortgage_mdp_field_mortgag1_sdat_field_92")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment1Mortgage { get; set; }

        [JsonPropertyName("sales_segment_1_mkt_land_value_sdat_field_95")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment1MarketLandValue { get; set; }

        [JsonPropertyName("sales_segment_1_mkt_improvement_value_sdat_field_96")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment1MarketImprovementValue { get; set; }

        [JsonPropertyName("sales_segment_2_transfer_number_sdat_field_99")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment2TransferNumber { get; set; }

        [JsonPropertyName("sales_segment_2_grantor_deed_reference_1_liber_sdat_field_102")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment2GrantorDeedReferenceLiber { get; set; }

        [JsonPropertyName("sales_segment_2_grantor_deed_reference_1_folio_sdat_field_103")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment2GrantorDeedReferenceFolio { get; set; }

        [JsonPropertyName("sales_segment_2_how_conveyed_ind_sdat_field_107")]
        [JsonConverter(typeof(StringWithNoDataNulledJsonConverter))]
        public string? SalesSegment2HowConveyed { get; set; }

        [JsonPropertyName("sales_segment_2_transfer_date_yyyy_mm_dd_sdat_field_109")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SalesSegment2TransferDate { get; set; }

        [JsonPropertyName("sales_segment_2_consideration_sdat_field_110")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment2Consideration { get; set; }

        [JsonPropertyName("sales_segment_2_mortgage_sdat_field_112")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment2Mortgage { get; set; }

        [JsonPropertyName("sales_segment_2_mkt_land_value_sdat_field_115")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment2MarketLandValue { get; set; }

        [JsonPropertyName("sales_segment_2_mkt_improvement_value_sdat_field_116")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment2MarketImprovementValue { get; set; }

        [JsonPropertyName("sales_segment_3_transfer_number_sdat_field_119")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment3TransferNumber { get; set; }

        [JsonPropertyName("sales_segment_3_grantor_deed_reference_1_liber_sdat_field_122")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment3GrantorDeedReferenceLiber { get; set; }

        [JsonPropertyName("sales_segment_3_grantor_deed_reference_1_folio_sdat_field_123")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? SalesSegment3GrantorDeedReferenceFolio { get; set; }

        [JsonPropertyName("sales_segment_3_how_conveyed_ind_sdat_field_127")]
        [JsonConverter(typeof(StringWithNoDataNulledJsonConverter))]
        public string? SalesSegment3HowConveyed { get; set; }

        [JsonPropertyName("sales_segment_3_transfer_date_yyyy_mm_dd_sdat_field_129")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SalesSegment3TransferDate { get; set; }

        [JsonPropertyName("sales_segment_3_consideration_sdat_field_130")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment3Consideration { get; set; }

        [JsonPropertyName("sales_segment_3_mortgage_sdat_field_132")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment3Mortgage { get; set; }

        [JsonPropertyName("sales_segment_3_mkt_land_value_sdat_field_135")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment3MarketLandValue { get; set; }

        [JsonPropertyName("sales_segment_3_mkt_improvement_value_sdat_field_136")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SalesSegment3MarketImprovementValue { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_county_exempt_assessment_sdat_field_140")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsCountyExemptAssessment { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_county_exempt_percentage_sdat_field_141")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsCountyExemptPercentage { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_state_exempt_assessment_sdat_field_143")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsStateExemptAssessment { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_state_exempt_percentage_sdat_field_144")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsStateExemptPercentage { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_municipal_exempt_assessment_sdat_field_146")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsMunicipalExemptAssessment { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_municipal_exempt_percentage_sdat_field_147")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsMunicipalExemptPercentage { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_prior_exempt_county_assessment_sdat_field_148")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsPriorExemptCountyAssessment { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_prior_exempt_county_percent_sdat_field_149")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsPriorExemptCountyPercentage { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_prior_exempt_state_assessment_sdat_field_150")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsPriorExemptStateAssessment { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_prior_exempt_state_percent_sdat_field_151")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsPriorExemptStatePercentage { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_prior_exempt_municipal_assmt_sdat_field_152")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsPriorExemptMunicipalAssessment { get; set; }

        [JsonPropertyName("full_and_partial_exemptions_prior_exempt_municipal_percent_sdat_field_153")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int FullAndPartialExemptionsPriorExemptMunicipalPercentage { get; set; }

        [JsonPropertyName("base_cycle_data_land_value_sdat_field_154")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int BaseCycleDataLandValue { get; set; }

        [JsonPropertyName("base_cycle_data_improvements_value_sdat_field_155")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int BaseCycleDataImprovementsValue { get; set; }

        [JsonPropertyName("base_cycle_data_preferential_land_value_sdat_field_156")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int BaseCycleDataPreferentialLandValue { get; set; }

        [JsonPropertyName("base_cycle_data_circuit_breaker_value_sdat_field_157")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int BaseCycleDataCircuitBreakerValue { get; set; }

        [JsonPropertyName("base_cycle_data_date_assessed_yyyy_mm_sdat_field_158")]
        [JsonConverter(typeof(DateOnlyWithoutDayJsonConverter))]
        public DateOnly? BaseCycleDataDateAssessed { get; set; }

        [JsonPropertyName("base_cycle_data_date_inspected_yyyy_mm_sdat_field_159")]
        [JsonConverter(typeof(DateOnlyWithoutDayJsonConverter))]
        public DateOnly? BaseCycleDataDateInspected { get; set; }

        [JsonPropertyName("prior_assessment_year_total_assessment_sdat_field_161")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int PriorAssessmentYearTotalAssessment { get; set; }

        [JsonPropertyName("prior_assessment_year_circuit_breaker_assessment_sdat_field_163")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int PriorAssessmentYearCircuitBreakerAssessment { get; set; }

        [JsonPropertyName("current_cycle_data_land_value_mdp_field_names_nfmlndvl_curlndvl_and_sallndvl_sdat_field_164")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentCycleDataLandValue { get; set; }

        [JsonPropertyName("current_cycle_data_improvements_value_mdp_field_names_nfmimpvl_curimpvl_and_salimpvl_sdat_field_165")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentCycleDataImprovementsValue { get; set; }

        [JsonPropertyName("current_cycle_data_preferential_land_value_sdat_field_166")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentCycleDataPreferentialLandValue { get; set; }

        [JsonPropertyName("current_cycle_data_circuit_breaker_value_sdat_field_167")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentCycleDataCircuitBreakerValue { get; set; }

        [JsonPropertyName("current_cycle_data_date_inspected_yyyy_mm_mdp_field_lastinsp_sdat_field_168")]
        [JsonConverter(typeof(DateOnlyWithoutDayJsonConverter))]
        public DateOnly? CurrentCycleDataDateInspected { get; set; }

        [JsonPropertyName("current_cycle_data_date_assessed_yyyy_mm_mdp_field_lastassd_sdat_field_169")]
        [JsonConverter(typeof(DateOnlyWithoutDayJsonConverter))]
        public DateOnly? CurrentCycleDataDateAssessed { get; set; }

        [JsonPropertyName("current_assessment_year_total_phase_in_value_sdat_field_171")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentAssessmentYearTotalPhaseInValue { get; set; }

        [JsonPropertyName("current_assessment_year_total_assessment_sdat_field_172")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentAssessmentYearTotalAssessment { get; set; }

        [JsonPropertyName("current_assessment_year_circuit_breaker_phase_in_value_sdat_field_175")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentAssessmentYearCircuitBreakerPhaseInValue { get; set; }

        [JsonPropertyName("current_assessment_year_circuit_breaker_assessment_sdat_field_176")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CurrentAssessmentYearCircuitBreakerAssessment { get; set; }

        [JsonPropertyName("new_construction_data_base_land_value_sdat_field_184")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataBaseLandValue { get; set; }

        [JsonPropertyName("new_construction_data_base_improvement_value_sdat_field_185")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataBaseImprovementValue { get; set; }

        [JsonPropertyName("new_construction_data_proposed_land_value_sdat_field_186")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataProposedLandValue { get; set; }

        [JsonPropertyName("new_construction_data_proposed_improvement_value_sdat_field_187")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataProposedImprovementValue { get; set; }

        [JsonPropertyName("new_construction_data_activity_tax_year_as_of_july_1_sdat_field_189")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? NewConstructionDataActivityTaxYear { get; set; }

        [JsonPropertyName("new_construction_data_date_updated_yyyy_mm_dd_sdat_field_191")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? NewConstructionDataDateUpdated { get; set; }

        [JsonPropertyName("new_construction_data_county_assessment_credit_sdat_field_192")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataCountyAssessmentCredit { get; set; }

        [JsonPropertyName("new_construction_data_state_assessment_credit_sdat_field_193")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataStateAssessmentCredit { get; set; }

        [JsonPropertyName("new_construction_data_municipal_assessment_credit_sdat_field_194")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int NewConstructionDataMunicipalAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_previous_state_assmt_cr_sdat_field_196")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramPreviousStateAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_current_state_assmt_cr_sdat_field_197")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramCurrentStateAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_previous_county_assmt_cr_sdat_field_198")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramPreviousCountyAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_current_county_assmt_cr_sdat_field_199")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramCurrentCountyAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_previous_municipal_assmt_cr_sdat_field_200")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramPreviousMunicipalAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_current_municipal_assmt_cr_sdat_field_201")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramCurrentMunicipalAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_prior_year_3_state_assmt_cr_sdat_field_204")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramPriorYear3StateAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_prior_year_3_county_assmt_cr_sdat_field_205")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramPriorYear3CountyAssessmentCredit { get; set; }

        [JsonPropertyName("assessment_credit_program_prior_year_3_municipal_assmt_cr_sdat_field_206")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int AssessmentCreditProgramPriorYear3MunicipalAssessmentCredit { get; set; }

        [JsonPropertyName("special_dates_and_data_fcma_code_mdp_field_fcmacode_sdat_field_207")]
        [JsonConverter(typeof(SpecialDatesAndDataFCMACodeJsonConverter))]
        public string? SpecialDatesAndDataFCMACode { get; set; }

        [JsonPropertyName("special_dates_and_data_rezoned_reality_date_yyyy_mm_dd_mdp_field_rzrealdat_sdat_field_208")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataRezonedRealityDate { get; set; }

        [JsonPropertyName("special_dates_and_data_inchoate_lien_date_yyyy_mm_dd_sdat_field_209")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataInchoateLienDate { get; set; }

        [JsonPropertyName("special_dates_and_data_country_club_assmt_date_yyyy_mm_dd_sdat_field_210")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataCountryClubAssessmentDate { get; set; }

        [JsonPropertyName("special_dates_and_data_country_club_expiration_date_yyyy_mm_dd_sdat_field_211")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataCountryClubExpirationDate { get; set; }

        [JsonPropertyName("special_dates_and_data_country_club_extension_date_yyyy_mm_dd_sdat_field_212")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataCountryClubExtensionDate { get; set; }

        [JsonPropertyName("special_dates_and_data_agr_land_preservation_fdn_area_mdp_field_agfndarea_sdat_field_213")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SpecialDatesAndDataAgriculturalLandPreservationFDNArea { get; set; }

        [JsonPropertyName("special_dates_and_data_enterprise_zone_date_yyyy_mm_dd_mdp_field_entzndat_sdat_field_215")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataEnterpriseZoneDate { get; set; }

        [JsonPropertyName("special_dates_and_data_enterprise_zone_assessment_mdp_field_entznassm_sdat_field_216")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SpecialDatesAndDataEnterpriseZoneAssessment { get; set; }

        [JsonPropertyName("special_dates_and_data_planned_development_date_yyyy_mm_dd_mdp_field_plndevdat_sdat_field_217")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataPlannedDevelopmentDate { get; set; }

        [JsonPropertyName("special_dates_and_data_non_perc_test_date_yyyy_mm_dd_mdp_field_nprctstdat_sdat_field_218")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataNonPercTestDate { get; set; }

        [JsonPropertyName("special_dates_and_data_non_perc_area_mdp_field_nprcarea_sdat_field_219")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int SpecialDatesAndDataNonPercArea { get; set; }

        [JsonPropertyName("special_dates_and_data_ag_tax_liab_due_date_yyyy_mm_dd_sdat_field_221")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataAgriculturalTaxLiabilityDueDate { get; set; }

        [JsonPropertyName("special_dates_and_data_letter_of_intent_date_yyyy_mm_dd_sdat_field_222")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataLetterOfIntentDate { get; set; }

        [JsonPropertyName("special_dates_and_data_zoning_change_date_yyyy_mm_dd_mdp_field_znchgdat_sdat_field_224")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataZoningChangeDate { get; set; }

        [JsonPropertyName("special_dates_and_data_tax_court_date_yyyy_mm_dd_sdat_field_225")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataTaxCourtDate { get; set; }

        [JsonPropertyName("special_dates_and_data_appeal_board_date_yyyy_mm_dd_sdat_field_226")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? SpecialDatesAndDataAppealBoardDate { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_dwelling_grade_code_and_description_mdp_field_strugrad_strudesc_sdat_field_230")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? CAMASystemDataDwellingGradeCode { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_dwelling_condition_code_sdat_field_233")]
        [JsonConverter(typeof(StringWithBlankNone0Blank0NulledJsonConverter))]
        public string? CAMASystemDataDwellingConditionCode { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_year_built_yyyy_mdp_field_yearblt_sdat_field_235")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? CAMASystemDataYearBuilt { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_set_no_sdat_field_236")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? CAMASystemDataSetNumber { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_subset_no_sdat_field_237")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? CAMASystemDataSubsetNumber { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_number_of_dwelling_units_mdp_field_bldg_units_sdat_field_239")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CAMASystemDataNumberOfDwellingUnits { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_number_of_stories_mdp_field_bldg_story_sdat_field_240")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CAMASystemDataNumberOfStories { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_structure_area_sq_ft_mdp_field_sqftstrc_sdat_field_241")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CAMASystemDataStructureAreaSquareFeet { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_land_area_mdp_field_landarea_sdat_field_242")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CAMASystemDataLandArea { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_land_unit_of_measure_mdp_field_luom_sdat_field_243")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? CAMASystemDataLandUnitOfMeasure { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_effective_width_mdp_field_width_sdat_field_244")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CAMASystemDataEffectiveWidth { get; set; }

        [JsonPropertyName("c_a_m_a_system_data_effective_depth_mdp_field_depth_sdat_field_245")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int CAMASystemDataEffectiveDepth { get; set; }

        [JsonPropertyName("tax_roll_values_tax_year_as_of_july_1_sdat_field_246")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? TaxRollValuesTaxYear { get; set; }

        [JsonPropertyName("tax_roll_values_county_assessment_sdat_field_247")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesCountyAssessment { get; set; }

        [JsonPropertyName("tax_roll_values_state_assessment_sdat_field_248")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesStateAssessment { get; set; }

        [JsonPropertyName("tax_roll_values_municipal_assessment_sdat_field_249")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesMunicipalAssessment { get; set; }

        [JsonPropertyName("tax_roll_values_state_assessment_credit_sdat_field_250")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesStateAssessmentCredit { get; set; }

        [JsonPropertyName("tax_roll_values_county_assessment_credit_sdat_field_251")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesCountyAssessmentCredit { get; set; }

        [JsonPropertyName("tax_roll_values_municipal_assessment_credit_sdat_field_252")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesMunicipalAssessmentCredit { get; set; }

        [JsonPropertyName("tax_roll_values_homeowner_program_total_credit_sdat_field_253")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesHomeownerProgramTotalCredit { get; set; }

        [JsonPropertyName("tax_roll_values_homeowner_program_county_liab_sdat_field_254")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesHomeownerProgramCountyLiability { get; set; }

        [JsonPropertyName("tax_roll_values_homeowner_program_municp_liab_sdat_field_255")]
        [JsonConverter(typeof(IntJsonConverter))]
        public int TaxRollValuesHomeownerProgramMunicipalityLiability { get; set; }

        [JsonPropertyName("tax_roll_values_tax_roll_billing_date_yyyy_mm_dd_sdat_field_257")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? TaxRollValuesTaxRollBillingDate { get; set; }

        [JsonPropertyName("homestead_qualification_date_mdp_field_homqldat_sdat_field_260")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? HomesteadQualificationDate { get; set; }

        [JsonPropertyName("additional_c_a_m_a_data_permit_type_mdp_field_permittyp_sdat_field_262")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? AdditionalCAMADataPermitType { get; set; }

        [JsonPropertyName("additional_c_a_m_a_data_dwelling_construction_code_mdp_field_strucnst_sdat_field_263")]
        [JsonConverter(typeof(StringWithBlankNone0Blank0NulledJsonConverter))]
        public string? AdditionalCAMADataDwellingConstructionCode { get; set; }

        [JsonPropertyName("additional_c_a_m_a_data_building_style_code_and_description_mdp_field_strustyl_descstyl_sdat_field_264")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? AdditionalCAMADataBuildingStyleCodeAndDescription { get; set; }

        [JsonPropertyName("additional_c_a_m_a_data_dwelling_type_mdp_field_strubldg_sdat_field_265")]
        [JsonConverter(typeof(StringWithBlankNoneNulledJsonConverter))]
        public string? AdditionalCAMADataDwellingType { get; set; }

        [JsonPropertyName("additional_c_a_m_a_data_land_valuation_unit_sdat_field_266")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? AdditionalCAMADataLandValuationUnit { get; set; }

        [JsonPropertyName("plat_reference_liber_mdp_field_pltliber_sdat_field_267")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? PlatReferenceLiber { get; set; }

        [JsonPropertyName("plat_reference_folio_mdp_field_pltfolio_sdat_field_268")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? PlatReferenceFolio { get; set; }

        [JsonPropertyName("parent_account_number_district_ward_sdat_field_387")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? ParentAccountNumberDistrictWard { get; set; }

        [JsonPropertyName("parent_account_number_account_number_sdat_field_388")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? ParentAccountNumberAccountNumber { get; set; }

        [JsonPropertyName("last_activity_date_yyyy_mm_dd_sdat_field_392")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? LastActivityDate { get; set; }

        [JsonPropertyName("record_creation_date_yyyy_mm_dd_sdat_field_397")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? RecordCreationDate { get; set; }

        [JsonPropertyName("record_creation_date_yyyy_mm_dd_sdat_field_397")]
        [JsonConverter(typeof(RecordCreationYearJsonConverter))]
        public string? RecordCreationYear { get; set; }

        [JsonPropertyName("record_deletion_date_yyyy_mm_dd_sdat_field_398")]
        [JsonConverter(typeof(DateOnlyWithDayJsonConverter))]
        public DateOnly? RecordDeletionDate { get; set; }

        [JsonPropertyName("record_deletion_date_yyyy_mm_dd_sdat_field_398")]
        [JsonConverter(typeof(RecordCreationYearJsonConverter))]
        public string? RecordDeletionYear { get; set; }

        [JsonPropertyName("assessment_cycle_year_sdat_field_399")]
        [JsonConverter(typeof(StringWithAllZeroesNulledJsonConverter))]
        public string? AssessmentCycleYear { get; set; }

        [JsonPropertyName("file_record_type_sdat_field_400")]
        [JsonConverter(typeof(StringJsonConverter))]
        public string? FileRecordType { get; set; }

        [JsonPropertyName("date_of_most_recent_open_data_portal_record_update")]
        [JsonConverter(typeof(MostRecentOpenDataPortalRecordUpdateDateOnlyWithDayJsonConverter))]
        public DateOnly? MostRecentOpenDataPortalRecordUpdateDate { get; set; }
    }
}
