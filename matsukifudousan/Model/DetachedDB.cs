//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace matsukifudousan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetachedDB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetachedDB()
        {
            this.ImageDB = new HashSet<ImageDB>();
        }
    
        public int DetachedHouseNo { get; set; }
        public string DetachedHouseName { get; set; }
        public string DetachedPost { get; set; }
        public string DetachedAddress { get; set; }
        public string NearestSation { get; set; }
        public string Price { get; set; }
        public string FloorPlanType { get; set; }
        public string FloorPlanDetails { get; set; }
        public string LandArea { get; set; }
        public string BuildingArea { get; set; }
        public string BuildingStructure { get; set; }
        public string DateConstruction { get; set; }
        public string LandRights { get; set; }
        public string Ground { get; set; }
        public string CityPlanning { get; set; }
        public string UseDistrict { get; set; }
        public string BuildingCoverageRatio { get; set; }
        public string FloorAreaRatio { get; set; }
        public string OtherLegalRestrictions { get; set; }
        public string Terrain { get; set; }
        public string CurrentSituation { get; set; }
        public string DeliveryConditionTime { get; set; }
        public string Parking { get; set; }
        public string TransactionMode { get; set; }
        public string RoadsideSituation { get; set; }
        public string Facility { get; set; }
        public string SchoolDistrict { get; set; }
        public string NeighborhoodInformation { get; set; }
        public string Remarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageDB> ImageDB { get; set; }
    }
}
