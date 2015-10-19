// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ShipmentInvoiceJson.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
#pragma warning disable 0108
#pragma warning disable 1591

using __ShVendorJs1__ = global::ShipmentInvoiceJson.VendorJson.JsonByExample;
using __SVeNAME__ = global::ShipmentInvoiceJson.VendorJson.Input.NAME;
using __SVeBUSINESS__ = global::ShipmentInvoiceJson.VendorJson.Input.BUSINESS_NAME;
using __SVeEMAIL__ = global::ShipmentInvoiceJson.VendorJson.Input.EMAIL;
using __SVePHONE__ = global::ShipmentInvoiceJson.VendorJson.Input.PHONE;
using __SVeADDRESS__ = global::ShipmentInvoiceJson.VendorJson.Input.ADDRESS;
using __SVeAMOUNT__ = global::ShipmentInvoiceJson.VendorJson.Input.AMOUNT;
using __SVeOPENING___ = global::ShipmentInvoiceJson.VendorJson.Input.OPENING_BALANCE;
using __SVeBALANCE___ = global::ShipmentInvoiceJson.VendorJson.Input.BALANCE_LIMIT;
using __ShShipment3__ = global::ShipmentInvoiceJson.ShipmentJson;
using __ShShipment4__ = global::ShipmentInvoiceJson.ShipmentJson.JsonByExample;
using __ShShipment5__ = global::ShipmentInvoiceJson.ShipmentJson.Input;
using __SShID__ = global::ShipmentInvoiceJson.ShipmentJson.Input.ID;
using __SShNAME1__ = global::ShipmentInvoiceJson.ShipmentJson.Input.NAME;
using __SShDATED__ = global::ShipmentInvoiceJson.ShipmentJson.Input.DATED;
using __SShAMOUNT__ = global::ShipmentInvoiceJson.ShipmentJson.Input.AMOUNT;
using __SShREMARKS__ = global::ShipmentInvoiceJson.ShipmentJson.Input.REMARKS;
using __SShCUSTOMER__ = global::ShipmentInvoiceJson.ShipmentJson.Input.CUSTOMER_BALANCE;
using __SShTOTAL_CT__ = global::ShipmentInvoiceJson.ShipmentJson.Input.TOTAL_CTN;
using __Arr__ = global::Starcounter.Arr<global::ShipmentInvoiceJson.ShipmentDetailElementJson>;
using __SVeID__ = global::ShipmentInvoiceJson.VendorJson.Input.ID;
using __ShVendorJs2__ = global::ShipmentInvoiceJson.VendorJson.Input;
using __ShVendorPr__ = global::ShipmentInvoiceJson.Input.VendorPreviousBalance;
using __ShVendorJs__ = global::ShipmentInvoiceJson.VendorJson;
using __Shipment__ = global::ShipmentInvoiceJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __ShSchema__ = global::ShipmentInvoiceJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __SVeSchema__ = global::ShipmentInvoiceJson.VendorJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SShSchema__ = global::ShipmentInvoiceJson.ShipmentJson.JsonByExample.Schema;
using __Shipment2__ = global::ShipmentInvoiceJson.Input;
using __ShShipment__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson;
using __ShShipment1__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.JsonByExample;
using __ShShipment2__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.Input;
using __SShNAME__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.Input.NAME;
using __SShMODEL__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.Input.MODEL;
using __SShT_QUANTI__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.Input.T_QUANTITY;
using __SShPRICE__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.Input.PRICE;
using __SShSUBTOTAL__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.Input.SUBTOTAL;
using __TArray__ = global::Starcounter.Templates.TArray<global::ShipmentInvoiceJson.ShipmentDetailElementJson>;
using __Shipment1__ = global::ShipmentInvoiceJson.JsonByExample;
using __SShSchema1__ = global::ShipmentInvoiceJson.ShipmentDetailElementJson.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ShipmentInvoiceJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ShSchema__ DefaultTemplate = new __ShSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentInvoiceJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentInvoiceJson(__ShSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ShSchema__ Template { get { return (__ShSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__VendorPreviousBalance__;
    private __ShVendorJs__ __bf__Vendor__;
    private __ShShipment3__ __bf__Shipment__;
    private __Arr__ __bf__ShipmentDetail__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Shipment__);
                ClassName = "ShipmentInvoiceJson";
                Properties.ClearExposed();
                VendorPreviousBalance = Add<__TString__>("VendorPreviousBalance");
                VendorPreviousBalance.DefaultValue = "";
                VendorPreviousBalance.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__VendorPreviousBalance__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__VendorPreviousBalance__ = (System.String)_v_; }, false);
                Vendor = Add<__SVeSchema__>("Vendor");
                Vendor.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__Vendor__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__Vendor__ = (__ShVendorJs__)_v_; }, false);
                Shipment = Add<__SShSchema__>("Shipment");
                Shipment.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__Shipment__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__Shipment__ = (__ShShipment3__)_v_; }, false);
                ShipmentDetail = Add<__TArray__>("ShipmentDetail");
                ShipmentDetail.SetCustomGetElementType((arr) => { return __ShShipment__.DefaultTemplate;});
                ShipmentDetail.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__ShipmentDetail__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__ShipmentDetail__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Shipment__(this) { Parent = parent }; }
            public __TString__ VendorPreviousBalance;
            public __SVeSchema__ Vendor;
            public __SShSchema__ Shipment;
            public __TArray__ ShipmentDetail;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String VendorPreviousBalance {
#line 2 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.VendorPreviousBalance.Getter(this); }
#line 2 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.VendorPreviousBalance.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __ShVendorJs__ Vendor {
#line 13 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return (__ShVendorJs__)Template.Vendor.Getter(this); }
#line 13 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.Vendor.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __ShShipment3__ Shipment {
#line 22 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return (__ShShipment3__)Template.Shipment.Getter(this); }
#line 22 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.Shipment.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ ShipmentDetail {
#line 32 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.ShipmentDetail.Getter(this); }
#line 32 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.ShipmentDetail.Setter(this, value); } }
#line default

    
    #line hidden
    public class VendorJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SVeSchema__ DefaultTemplate = new __SVeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorJson(__SVeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SVeSchema__ Template { get { return (__SVeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__BUSINESS_NAME__;
        private System.String __bf__EMAIL__;
        private System.String __bf__PHONE__;
        private System.String __bf__ADDRESS__;
        private System.Int64 __bf__AMOUNT__;
        private System.Int64 __bf__OPENING_BALANCE__;
        private System.Int64 __bf__BALANCE_LIMIT__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ShVendorJs__);
                    ClassName = "VendorJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    BUSINESS_NAME = Add<__TString__>("BUSINESS_NAME");
                    BUSINESS_NAME.DefaultValue = "";
                    BUSINESS_NAME.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__BUSINESS_NAME__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__BUSINESS_NAME__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__ShVendorJs__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__ShVendorJs__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShVendorJs__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ BUSINESS_NAME;
                public __TString__ EMAIL;
                public __TString__ PHONE;
                public __TString__ ADDRESS;
                public __TLong__ AMOUNT;
                public __TLong__ OPENING_BALANCE;
                public __TLong__ BALANCE_LIMIT;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 4 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 4 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 5 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 5 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String BUSINESS_NAME {
#line 6 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.BUSINESS_NAME.Getter(this); }
#line 6 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.BUSINESS_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 7 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 7 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 8 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 8 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 9 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 9 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 10 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 10 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 11 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 11 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 13 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 13 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__ShVendorJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__ShVendorJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class BUSINESS_NAME : Input<__ShVendorJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__ShVendorJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__ShVendorJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__ShVendorJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__ShVendorJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__ShVendorJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__ShVendorJs__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public class ShipmentJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SShSchema__ DefaultTemplate = new __SShSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentJson(__SShSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SShSchema__ Template { get { return (__SShSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__DATED__;
        private System.Int64 __bf__AMOUNT__;
        private System.String __bf__REMARKS__;
        private System.Int64 __bf__CUSTOMER_BALANCE__;
        private System.Int64 __bf__TOTAL_CTN__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ShShipment3__);
                    ClassName = "ShipmentJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    DATED = Add<__TString__>("DATED");
                    DATED.DefaultValue = "";
                    DATED.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    REMARKS = Add<__TString__>("REMARKS");
                    REMARKS.DefaultValue = "";
                    REMARKS.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__REMARKS__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__REMARKS__ = (System.String)_v_; }, false);
                    CUSTOMER_BALANCE = Add<__TLong__>("CUSTOMER_BALANCE");
                    CUSTOMER_BALANCE.DefaultValue = 0L;
                    CUSTOMER_BALANCE.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__CUSTOMER_BALANCE__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__CUSTOMER_BALANCE__ = (System.Int64)_v_; }, false);
                    TOTAL_CTN = Add<__TLong__>("TOTAL_CTN");
                    TOTAL_CTN.DefaultValue = 0L;
                    TOTAL_CTN.SetCustomAccessors((_p_) => { return ((__ShShipment3__)_p_).__bf__TOTAL_CTN__; }, (_p_, _v_) => { ((__ShShipment3__)_p_).__bf__TOTAL_CTN__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment3__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ DATED;
                public __TLong__ AMOUNT;
                public __TString__ REMARKS;
                public __TLong__ CUSTOMER_BALANCE;
                public __TLong__ TOTAL_CTN;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 15 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 15 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 16 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 16 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DATED {
#line 17 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 17 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 18 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 18 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String REMARKS {
#line 19 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.REMARKS.Getter(this); }
#line 19 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.REMARKS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CUSTOMER_BALANCE {
#line 20 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.CUSTOMER_BALANCE.Getter(this); }
#line 20 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.CUSTOMER_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 TOTAL_CTN {
#line 22 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.TOTAL_CTN.Getter(this); }
#line 22 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.TOTAL_CTN.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__ShShipment3__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__ShShipment3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DATED : Input<__ShShipment3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__ShShipment3__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class REMARKS : Input<__ShShipment3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CUSTOMER_BALANCE : Input<__ShShipment3__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class TOTAL_CTN : Input<__ShShipment3__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public class ShipmentDetailElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SShSchema1__ DefaultTemplate = new __SShSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentDetailElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentDetailElementJson(__SShSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SShSchema1__ Template { get { return (__SShSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__NAME__;
        private System.String __bf__MODEL__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.Int64 __bf__PRICE__;
        private System.Int64 __bf__SUBTOTAL__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ShShipment__);
                    ClassName = "ShipmentDetailElementJson";
                    Properties.ClearExposed();
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    PRICE = Add<__TLong__>("PRICE");
                    PRICE.DefaultValue = 0L;
                    PRICE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__PRICE__ = (System.Int64)_v_; }, false);
                    SUBTOTAL = Add<__TLong__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0L;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__SUBTOTAL__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment__(this) { Parent = parent }; }
                public __TString__ NAME;
                public __TString__ MODEL;
                public __TLong__ T_QUANTITY;
                public __TLong__ PRICE;
                public __TLong__ SUBTOTAL;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 25 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 25 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 26 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 26 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 27 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 27 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 PRICE {
#line 28 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 28 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SUBTOTAL {
#line 30 "Server\Partials\ShipmentInvoiceJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 30 "Server\Partials\ShipmentInvoiceJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class NAME : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public static class Input {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class VendorPreviousBalance : Input<__Shipment__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108