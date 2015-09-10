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

using __SShVendorJs__ = global::ShipmentJson.ShipmentsElementJson.VendorJson;
using __Shipment1__ = global::ShipmentJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ShipmentJson.ShipmentsElementJson>;
using __SShDESCRIPT__ = global::ShipmentJson.ShipmentsElementJson.Input.DESCRIPTION;
using __SShSHIP_DAT__ = global::ShipmentJson.ShipmentsElementJson.Input.SHIP_DATE;
using __SShNAME__ = global::ShipmentJson.ShipmentsElementJson.Input.NAME;
using __SShID__ = global::ShipmentJson.ShipmentsElementJson.Input.ID;
using __ShShipment2__ = global::ShipmentJson.ShipmentsElementJson.Input;
using __SSVeNAME__ = global::ShipmentJson.ShipmentsElementJson.VendorJson.Input.NAME;
using __SSVeID__ = global::ShipmentJson.ShipmentsElementJson.VendorJson.Input.ID;
using __SShVendorJs2__ = global::ShipmentJson.ShipmentsElementJson.VendorJson.Input;
using __SShVendorJs1__ = global::ShipmentJson.ShipmentsElementJson.VendorJson.JsonByExample;
using __Shipment2__ = global::ShipmentJson.Input;
using __ShShipment1__ = global::ShipmentJson.ShipmentsElementJson.JsonByExample;
using __SSVeSchema__ = global::ShipmentJson.ShipmentsElementJson.VendorJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SShSchema__ = global::ShipmentJson.ShipmentsElementJson.JsonByExample.Schema;
using __ShShipment__ = global::ShipmentJson.ShipmentsElementJson;
using __ShSchema__ = global::ShipmentJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Shipment__ = global::ShipmentJson;
using __Arr__ = global::Starcounter.Arr<global::ShipmentJson.ShipmentsElementJson>;

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
#line 12 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.Shipments.Getter(this); }
#line 12 "Server\Partials\ShipmentJson.json"
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
        private System.String __bf__SHIP_DATE__;
        private System.String __bf__DESCRIPTION__;
        private __SShVendorJs__ __bf__Vendor__;
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
                    SHIP_DATE = Add<__TString__>("SHIP_DATE");
                    SHIP_DATE.DefaultValue = "";
                    SHIP_DATE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__SHIP_DATE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__SHIP_DATE__ = (System.String)_v_; }, false);
                    DESCRIPTION = Add<__TString__>("DESCRIPTION");
                    DESCRIPTION.DefaultValue = "";
                    DESCRIPTION.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__DESCRIPTION__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__DESCRIPTION__ = (System.String)_v_; }, false);
                    Vendor = Add<__SSVeSchema__>("Vendor");
                    Vendor.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Vendor__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Vendor__ = (__SShVendorJs__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ SHIP_DATE;
                public __TString__ DESCRIPTION;
                public __SSVeSchema__ Vendor;
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
        public System.String SHIP_DATE {
#line 5 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.SHIP_DATE.Getter(this); }
#line 5 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.SHIP_DATE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DESCRIPTION {
#line 6 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.DESCRIPTION.Getter(this); }
#line 6 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.DESCRIPTION.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __SShVendorJs__ Vendor {
#line 11 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return (__SShVendorJs__)Template.Vendor.Getter(this); }
#line 11 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.Vendor.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class VendorJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __SSVeSchema__ DefaultTemplate = new __SSVeSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public VendorJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public VendorJson(__SSVeSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __SSVeSchema__ Template { get { return (__SSVeSchema__)base.Template; } set { base.Template = value; } }
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
                        InstanceType = typeof(__SShVendorJs__);
                        ClassName = "VendorJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__SShVendorJs__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__SShVendorJs__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__SShVendorJs__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__SShVendorJs__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __SShVendorJs__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __TString__ NAME;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 8 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 8 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 10 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 10 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ID : Input<__SShVendorJs__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class NAME : Input<__SShVendorJs__, __TString__, string> {
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