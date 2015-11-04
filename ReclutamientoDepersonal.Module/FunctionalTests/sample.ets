;#DropDB ReclutamientoDepersonalEasyTest

#Application ReclutamientoDepersonal.Win
#Application ReclutamientoDepersonal.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef ReclutamientoDepersonal.Win

*Action About...
 
*Action OK

#EndIf

#IfDef ReclutamientoDepersonal.Web

*Action Choose Theme(Black Glass)

#EndIf
