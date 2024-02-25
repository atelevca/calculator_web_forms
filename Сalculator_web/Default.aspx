<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Сalculator_web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <main class="d-flex flex-column align-items-end gap-4 col-8">
        <asp:TextBox CssClass="form-control form-control-lg text-center col-12" ID="TextBoxResult" runat="server" Text="0" ReadOnly="true"></asp:TextBox>

        <div class="d-flex flex-column gap-3 mt-3">
            <div class="d-flex gap-3">

                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonPi" runat="server" Text="π" OnClick="ButtonPi_Click" />
                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonSqrt" runat="server" Text="√" OnClick="ButtonSqrt_Click" />
                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonPower2" runat="server" Text="x²" OnClick="ButtonPower2_Click" />
                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonPower3" runat="server" Text="x³" OnClick="ButtonPower3_Click" />

                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonMod" runat="server" Text="|x|" OnClick="ButtonMod_Click" />
                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonFact" runat="server" Text="x!" OnClick="ButtonFact_Click" />
                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonPercent" runat="server" Text="%" OnClick="ButtonPercent_Click" />
                <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonOneDivideX" runat="server" Text="1/x" OnClick="ButtonOneDivideX_Click" />


            </div>

            <div class="d-flex gap-3">
                <div class="d-flex flex-column gap-3">
                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button7" runat="server" Text="7" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button8" runat="server" Text="8" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button9" runat="server" Text="9" OnClick="ButtonNumericOperation_Click" />
                    </div>

                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button4" runat="server" Text="4" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button5" runat="server" Text="5" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button6" runat="server" Text="6" OnClick="ButtonNumericOperation_Click" />
                    </div>

                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button1" runat="server" Text="1" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button2" runat="server" Text="2" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button3" runat="server" Text="3" OnClick="ButtonNumericOperation_Click" />
                    </div>

                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="Button0" runat="server" Text="0" OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonDot" runat="server" Text="." OnClick="ButtonNumericOperation_Click" />
                        <asp:Button CssClass="btn btn-warning btn-lg waves-effect shadow-sm" ID="ButtonClear" runat="server" Text="AC" OnClick="ButtonClear_Click" />
                    </div>

                </div>

                <div class="d-flex flex-column gap-3">
                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-info btn-lg waves-effect text-light shadow-sm" ID="ButtonPlus" runat="server" Text="+" OnClick="Operation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonSinh" runat="server" Text="Sinh" OnClick="ButtonSinh_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonSin" runat="server" Text="Sin" OnClick="ButtonSin_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonDec" runat="server" Text="Dec" OnClick="ButtonDec_Click" />
                    </div>

                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-info btn-lg waves-effect text-light shadow-sm" ID="Button10" runat="server" Text="-" OnClick="Operation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonCosh" runat="server" Text="Cosh" OnClick="ButtonCosh_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonCos" runat="server" Text="Cos" OnClick="ButtonCos_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonBin" runat="server" Text="Bin" OnClick="ButtonBin_Click" />
                    </div>

                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-info btn-lg waves-effect text-light shadow-sm" ID="ButtonMult" runat="server" Text="*" OnClick="Operation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonTanh" runat="server" Text="Tanh" OnClick="ButtonTanh_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonTan" runat="server" Text="Tan" OnClick="ButtonTan_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonHex" runat="server" Text="Hex" OnClick="ButtonHex_Click" />
                    </div>

                    <div class="d-flex gap-3">
                        <asp:Button CssClass="btn btn-info btn-lg waves-effect text-light shadow-sm" ID="ButtonDiv" runat="server" Text="/" OnClick="Operation_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonLog" runat="server" Text="Log" OnClick="ButtonLog_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonLn" runat="server" Text="Ln" OnClick="ButtonLn_Click" />
                        <asp:Button CssClass="btn btn-light btn-lg waves-effect shadow-sm" ID="ButtonOct" runat="server" Text="Oct" OnClick="ButtonOct_Click" />
                    </div>
                </div>

                <asp:Button CssClass="btn btn-success btn-lg shadow-sm" ID="ButtonEqual" runat="server" Text="=" OnClick="ButtonEqual_Click" />
            </div>
        </div>
    </main>

</asp:Content>
