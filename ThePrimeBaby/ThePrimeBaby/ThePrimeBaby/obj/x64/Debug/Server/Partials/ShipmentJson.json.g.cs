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

using __ShShipment1__ = global::ShipmentJson.ShipmentsElementJson.JsonByExample;
using __Shipment1__ = global::ShipmentJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ShipmentJson.ShipmentsElementJson>;
using __SShVendor__ = global::ShipmentJson.ShipmentsElementJson.Input.Vendor;
using __SShDESCRIPT__ = global::ShipmentJson.ShipmentsElementJson.Input.DESCRIPTION;
using __SShSHIP_DAT__ = global::ShipmentJson.ShipmentsElementJson.Input.SHIP_DATE;
using __SShName__ = global::ShipmentJson.ShipmentsElementJson.Input.Name;
using __SShID__ = global::ShipmentJson.ShipmentsElementJson.Input.ID;
using __ShShipment2__ = global::ShipmentJson.ShipmentsElementJson.Input;
using __Arr__ = global::Starcounter.Arr<global::ShipmentJson.ShipmentsElementJson>;
using __Shipment2__ = global::ShipmentJson.Input;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SShSchema__ = global::ShipmentJson.ShipmentsElementJson.JsonByExample.Schema;
using __ShShipment__ = global::ShipmentJson.ShipmentsElementJson;
using __ShSchema__ = global::ShipmentJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Shipment__ = global::ShipmentJson;
using __TString__ = global::Starcounter.Templates.TString;

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
#line 9 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.Shipments.Getter(this); }
#line 9 "Server\Partials\ShipmentJson.json"
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
        private System.String __bf__Name__;
        private System.String __bf__SHIP_DATE__;
        private System.String __bf__DESCRIPTION__;
        private System.String __bf__Vendor__;
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
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    SHIP_DATE = Add<__TString__>("SHIP_DATE");
                    SHIP_DATE.DefaultValue = "";
                    SHIP_DATE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__SHIP_DATE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__SHIP_DATE__ = (System.String)_v_; }, false);
                    DESCRIPTION = Add<__TString__>("DESCRIPTION");
                    DESCRIPTION.DefaultValue = "";
                    DESCRIPTION.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__DESCRIPTION__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__DESCRIPTION__ = (System.String)_v_; }, false);
                    Vendor = Add<__TString__>("Vendor");
                    Vendor.DefaultValue = "";
                    Vendor.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Vendor__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Vendor__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ Name;
                public __TString__ SHIP_DATE;
                public __TString__ DESCRIPTION;
                public __TString__ Vendor;
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
        public System.String Name {
#line 4 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 4 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
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
        public System.String Vendor {
#line 8 "Server\Partials\ShipmentJson.json"
    get {
#line hidden
        return Template.Vendor.Getter(this); }
#line 8 "Server\Partials\ShipmentJson.json"
    set {
#line hidden
        Template.Vendor.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Name : Input<__ShShipment__, __TString__, string> {
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
            
            #line hidden
            public class Vendor : Input<__ShShipment__, __TString__, string> {
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