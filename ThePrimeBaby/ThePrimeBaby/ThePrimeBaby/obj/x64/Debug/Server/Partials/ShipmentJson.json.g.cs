// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ShipmentJson.json"
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

using __SShVENDORJs1__ = global::ShipmentJson.ShipmentsElementJson.VENDORJson.JsonByExample;
using __Shipment1__ = global::ShipmentJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ShipmentJson.ShipmentsElementJson>;
using __SShDESCRIPT__ = global::ShipmentJson.ShipmentsElementJson.Input.DESCRIPTION;
using __SShSHIP_DAT__ = global::ShipmentJson.ShipmentsElementJson.Input.SHIP_DATE;
using __SShVENDOR_B__ = global::ShipmentJson.ShipmentsElementJson.Input.VENDOR_BALANCE;
using __SShAMOUNT__ = global::ShipmentJson.ShipmentsElementJson.Input.AMOUNT;
using __SShNAME__ = global::ShipmentJson.ShipmentsElementJson.Input.NAME;
using __SShID__ = global::ShipmentJson.ShipmentsElementJson.Input.ID;
using __ShShipment2__ = global::ShipmentJson.ShipmentsElementJson.Input;
using __SSVENAME__ = global::ShipmentJson.ShipmentsElementJson.VENDORJson.Input.NAME;
using __SSVEID__ = global::ShipmentJson.ShipmentsElementJson.VENDORJson.Input.ID;
using __SShVENDORJs2__ = global::ShipmentJson.ShipmentsElementJson.VENDORJson.Input;
using __Arr__ = global::Starcounter.Arr<global::ShipmentJson.ShipmentsElementJson>;
using __Shipment2__ = global::ShipmentJson.Input;
using __ShShipment1__ = global::ShipmentJson.ShipmentsElementJson.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __SSVESchema__ = global::ShipmentJson.ShipmentsElementJson.VENDORJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SShSchema__ = global::ShipmentJson.ShipmentsElementJson.JsonByExample.Schema;
using __ShShipment__ = global::ShipmentJson.ShipmentsElementJson;
using __ShSchema__ = global::ShipmentJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Shipment__ = global::ShipmentJson;
using __SShVENDORJs__ = global::ShipmentJson.ShipmentsElementJson.VENDORJson;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ShipmentJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ShSchema__ DefaultTemplate = new __ShSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentJson(__ShSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ShSchema__ Template { get { return (__ShSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Shipments__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Shipment__);
                ClassName = "ShipmentJson";
                Properties.ClearExposed();
                Shipments = Add<__TArray__>("Shipments");
                Shipments.SetCustomGetElementType((arr) => { return __ShShipment__.DefaultTemplate;});
                Shipments.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__Shipments__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__Shipments__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Shipment__(this) { Parent = parent }; }
            public __TArray__ Shipments;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Shipments {
#line 14 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.Shipments.Getter(this); }
#line 14 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.Shipments.Setter(this, value); } }
#line default

    
    #line hidden
    public class ShipmentsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SShSchema__ DefaultTemplate = new __SShSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentsElementJson(__SShSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SShSchema__ Template { get { return (__SShSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private __SShVENDORJs__ __bf__VENDOR__;
        private System.Decimal __bf__AMOUNT__;
        private System.Decimal __bf__VENDOR_BALANCE__;
        private System.String __bf__SHIP_DATE__;
        private System.String __bf__DESCRIPTION__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ShShipment__);
                    ClassName = "ShipmentsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    VENDOR = Add<__SSVESchema__>("VENDOR");
                    VENDOR.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__VENDOR__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__VENDOR__ = (__SShVENDORJs__)_v_; }, false);
                    AMOUNT = Add<__TDecimal__>("AMOUNT");
                    AMOUNT.DefaultValue = 0.0m;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__AMOUNT__ = (System.Decimal)_v_; }, false);
                    VENDOR_BALANCE = Add<__TDecimal__>("VENDOR_BALANCE");
                    VENDOR_BALANCE.DefaultValue = 0.0m;
                    VENDOR_BALANCE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__VENDOR_BALANCE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__VENDOR_BALANCE__ = (System.Decimal)_v_; }, false);
                    SHIP_DATE = Add<__TString__>("SHIP_DATE");
                    SHIP_DATE.DefaultValue = "";
                    SHIP_DATE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__SHIP_DATE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__SHIP_DATE__ = (System.String)_v_; }, false);
                    DESCRIPTION = Add<__TString__>("DESCRIPTION");
                    DESCRIPTION.DefaultValue = "";
                    DESCRIPTION.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__DESCRIPTION__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__DESCRIPTION__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __SSVESchema__ VENDOR;
                public __TDecimal__ AMOUNT;
                public __TDecimal__ VENDOR_BALANCE;
                public __TString__ SHIP_DATE;
                public __TString__ DESCRIPTION;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __SShVENDORJs__ VENDOR {
#line 8 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return (__SShVENDORJs__)Template.VENDOR.Getter(this); }
#line 8 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.VENDOR.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AMOUNT {
#line 9 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 9 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal VENDOR_BALANCE {
#line 10 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.VENDOR_BALANCE.Getter(this); }
#line 10 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.VENDOR_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SHIP_DATE {
#line 11 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.SHIP_DATE.Getter(this); }
#line 11 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.SHIP_DATE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DESCRIPTION {
#line 13 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.DESCRIPTION.Getter(this); }
#line 13 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.DESCRIPTION.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class VENDORJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __SSVESchema__ DefaultTemplate = new __SSVESchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public VENDORJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public VENDORJson(__SSVESchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __SSVESchema__ Template { get { return (__SSVESchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.Int64 __bf__ID__;
            private System.String __bf__NAME__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__SShVENDORJs__);
                        ClassName = "VENDORJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__SShVENDORJs__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__SShVENDORJs__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__SShVENDORJs__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__SShVENDORJs__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __SShVENDORJs__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __TString__ NAME;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 6 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 6 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 8 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 8 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ID : Input<__SShVENDORJs__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class NAME : Input<__SShVENDORJs__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__ShShipment__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class VENDOR_BALANCE : Input<__ShShipment__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class SHIP_DATE : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DESCRIPTION : Input<__ShShipment__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public static class Input {
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108