// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ShipmentDetailJson.json"
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

using __SShID__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.ID;
using __Shipment1__ = global::ShipmentDetailJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ShipmentDetailJson.ShipmentDetailsElementJson>;
using __SShSUBTOTAL__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.SUBTOTAL;
using __SShPRICE__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.PRICE;
using __SShCTN__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.CTN;
using __SShMODEL__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.MODEL;
using __SShQTY_PER___ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.QTY_PER_BOX;
using __SShT_QUANTI__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.T_QUANTITY;
using __SShItem__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.Item;
using __SShShipment__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.Shipment;
using __SShName__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.Name;
using __Arr__ = global::Starcounter.Arr<global::ShipmentDetailJson.ShipmentDetailsElementJson>;
using __Shipment2__ = global::ShipmentDetailJson.Input;
using __ShShipment1__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SShSchema__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.JsonByExample.Schema;
using __ShShipment__ = global::ShipmentDetailJson.ShipmentDetailsElementJson;
using __ShSchema__ = global::ShipmentDetailJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Shipment__ = global::ShipmentDetailJson;
using __ShShipment2__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ShipmentDetailJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ShSchema__ DefaultTemplate = new __ShSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentDetailJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentDetailJson(__ShSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ShSchema__ Template { get { return (__ShSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__ShipmentDetails__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Shipment__);
                ClassName = "ShipmentDetailJson";
                Properties.ClearExposed();
                ShipmentDetails = Add<__TArray__>("ShipmentDetails");
                ShipmentDetails.SetCustomGetElementType((arr) => { return __ShShipment__.DefaultTemplate;});
                ShipmentDetails.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__ShipmentDetails__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__ShipmentDetails__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Shipment__(this) { Parent = parent }; }
            public __TArray__ ShipmentDetails;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ ShipmentDetails {
#line 14 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.ShipmentDetails.Getter(this); }
#line 14 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.ShipmentDetails.Setter(this, value); } }
#line default

    
    #line hidden
    public class ShipmentDetailsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SShSchema__ DefaultTemplate = new __SShSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentDetailsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentDetailsElementJson(__SShSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SShSchema__ Template { get { return (__SShSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__Name__;
        private System.String __bf__Shipment__;
        private System.String __bf__Item__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.Int64 __bf__QTY_PER_BOX__;
        private System.String __bf__MODEL__;
        private System.Int64 __bf__CTN__;
        private System.Decimal __bf__PRICE__;
        private System.Decimal __bf__SUBTOTAL__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ShShipment__);
                    ClassName = "ShipmentDetailsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Shipment = Add<__TString__>("Shipment");
                    Shipment.DefaultValue = "";
                    Shipment.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Shipment__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Shipment__ = (System.String)_v_; }, false);
                    Item = Add<__TString__>("Item");
                    Item.DefaultValue = "";
                    Item.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Item__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Item__ = (System.String)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    QTY_PER_BOX = Add<__TLong__>("QTY_PER_BOX");
                    QTY_PER_BOX.DefaultValue = 0L;
                    QTY_PER_BOX.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__QTY_PER_BOX__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__QTY_PER_BOX__ = (System.Int64)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    CTN = Add<__TLong__>("CTN");
                    CTN.DefaultValue = 0L;
                    CTN.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__CTN__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__CTN__ = (System.Int64)_v_; }, false);
                    PRICE = Add<__TDecimal__>("PRICE");
                    PRICE.DefaultValue = 0.0m;
                    PRICE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__PRICE__ = (System.Decimal)_v_; }, false);
                    SUBTOTAL = Add<__TDecimal__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0.0m;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__SUBTOTAL__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ Name;
                public __TString__ Shipment;
                public __TString__ Item;
                public __TLong__ T_QUANTITY;
                public __TLong__ QTY_PER_BOX;
                public __TString__ MODEL;
                public __TLong__ CTN;
                public __TDecimal__ PRICE;
                public __TDecimal__ SUBTOTAL;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 4 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 4 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Shipment {
#line 5 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.Shipment.Getter(this); }
#line 5 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.Shipment.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Item {
#line 6 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.Item.Getter(this); }
#line 6 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.Item.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 7 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 7 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY_PER_BOX {
#line 8 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.QTY_PER_BOX.Getter(this); }
#line 8 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.QTY_PER_BOX.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 9 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 9 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CTN {
#line 10 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.CTN.Getter(this); }
#line 10 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal PRICE {
#line 11 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 11 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal SUBTOTAL {
#line 13 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 13 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
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
            public class Shipment : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Item : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class QTY_PER_BOX : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CTN : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__ShShipment__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__ShShipment__, __TDecimal__, Decimal> {
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