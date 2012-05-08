<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WEvents4ALL.login"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">


<div class="row">
	<div class="span10">
        <div class="form-horizontal" id="formLogin">
            <fieldset>
                <legend>Entrada de usuarios</legend>
                <div class="control-group">
                    <label class="control-label" for="inputLogNick">Nick</label>
                    <div class="controls">
                        <asp:TextBox ID="tbLoginUser" runat="server"></asp:TextBox>
                        <span class="help-inline hide">Debe poner un usuario valido.</span>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="inputLogPass">Contraseña</label>
                    <div class="controls">
                        <asp:TextBox ID="tbLoginPass" runat="server" TextMode="Password"></asp:TextBox>
                        <span class="help-inline hide">Debe poner una contraseña valida.</span>
                    </div>
                </div>
                <div class="form-actions">
                    <asp:Button ID="btLogin" runat="server" Text="Entrar" 
                        CssClass="btn btn-primary" onclick="Login_Usuario" />
                </div>
            </fieldset>
        </div>  
    </div>
</div>

	<script>

	    $(document).ready(function () {
	        $('#form1').on('submit', function (e) {
	            console.log('yes');
	            $('.help-inline').hide();
	            $('.control-group').removeClass('error');
	            if (validaLogin() == false)
	                e.preventDefault();
	        });
	    });

	    function validaLogin() {
	        var correcto = true;

	        var nick = $('#Content1_tbLoginUser');
	        var regexUserPass = /^([A-Za-z0-9])+$/;
	        if (nick.val() == "" || !regexUserPass.test(nick.val())) {
	            nick.parents('div.control-group').addClass('error').find('.help-inline').show();
	            correcto = false;
	        }

	        var pass = $('#Content1_tbLoginPass');
	        if (pass.val() == "" || !regexUserPass.test(pass.val())) {
	            pass.parents('div.control-group').addClass('error').find('.help-inline').show();
	            correcto = false;
	        }

	        return correcto;
	    }		
			
	</script>

</asp:Content>


