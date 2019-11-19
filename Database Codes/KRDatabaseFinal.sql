use master
go
if exists(select * from sys.databases where name='AndreaBD')
	drop database AndreaBD
go
create database AndreaBD
go
use AndreaBD
go 
/****** Object:  Table dbo.t_site    Script Date: 14/10/2017 16:36:27 ******/
create table t_site
	(
		id_site nvarchar(50),
		designation_site nvarchar(50),
		record_date date,
		constraint pk_site primary key(id_site)
	)
go
/****** Object:  Table dbo.t_casual    Script Date: 14/10/2017 16:36:27 ******/
create table t_casual
	(
		casual_ID nvarchar(50),
		complete_name_casual nvarchar(100),
		surname nvarchar(50),
		postname nvarchar(50),
		givenname nvarchar(50),
		sex nvarchar(50),
		constraint pk_casual primary key(casual_ID)
	)
go
/****** Object:  Table dbo.t_job_casual    Script Date: 14/10/2017 16:36:27 ******/
create table t_job_casual
	(
		id_job_casual_title nvarchar(50),
		id_job_casual_french nvarchar(50),
		constraint pk_job_casual primary key(id_job_casual_title)
	)
go
/****** Object:  Table dbo.t_engagement_casual    Script Date: 14/10/2017 16:36:27 ******/
create table t_engagement_casual
	(
		id_engagement_casual int identity(1,1),
		casual_ID nvarchar(50),
		date_engagement date,
		constraint pk_engagement_casual primary key(id_engagement_casual),
		constraint fk_casual_engagement foreign key(casual_ID) references t_casual(casual_ID)
	)
go
/****** Object:  Table dbo.t_affectation_site_casual    Script Date: 14/10/2017 16:36:27 ******/
create table t_affectation_site_casual
	(
		id_affectation_site_casual int identity(1,1),
		id_engagement_casual int,
		id_site nvarchar(50),
		id_job_casual_title nvarchar(50),
		date_affectation_site int,
		constraint pk_affec_site_cas primary key(id_affectation_site_casual),
		constraint fk_site_casual foreign key(id_site) references t_site(id_site),
		constraint fk_affec_job_casual foreign key(id_job_casual_title) references t_job_casual(id_job_casual_title),
		constraint fk_engagement_cas foreign key(id_engagement_casual) references t_engagement_casual(id_engagement_casual)
		)
go
/****** Object:  Table dbo.t_leave_site_casual    Script Date: 14/10/2017 16:36:27 ******/
create table t_offsite_casual
	(
		id_offsite_casual int identity(1,1),
		id_affectation_site_casual int,
		date_offsite date,
		reason_offsite nvarchar(50),
		comment_offsite nvarchar(50),
		constraint pk_offsite_casual primary key(id_offsite_casual),
		constraint fk_affec_site_cas foreign key(id_affectation_site_casual) references t_affectation_site_casual(id_affectation_site_casual)
		)
go
/****** Object:  Table dbo.t_visitors    Script Date: 14/10/2017 16:36:27 ******/

create table t_visitors
	(
		visitor_id nvarchar(50),
		complete_name_visitor nvarchar(50),
		surname nvarchar(50),
		postname nvarchar(50),
		givenname nvarchar(50),
		sex nvarchar(50),
		constraint pk_visitor primary key(visitor_id)
	)
go
/****** Object:  Table dbo.t_visits_checkin    Script Date: 14/10/2017 16:36:27 ******/
create table t_visits_checkin
	(
		id_visit_checkin int identity(1,1),
		visitor_id nvarchar(50),
		id_site nvarchar(50),
		job_title_visitor nvarchar(50),
		department nvarchar(50),
		check_in_date date,
		reason nvarchar(50),		
		constraint pk_visits_checkin primary key(id_visit_checkin),
		constraint fk_visitor_checkin foreign key(visitor_id) references t_visitors(visitor_id),
		constraint fk_visits_checkin_site foreign key(id_site) references t_site(id_site)
	)
go
/****** Object:  Table dbo.t_visits_checkout    Script Date: 14/10/2017 16:36:27 ******/
create table t_visits_checkout
	(
		id_visit_checkout int identity(1,1),
		id_visit_checkin int,
		check_out_date date,
		checkout_comment nvarchar(50),		
		constraint pk_visits_checkout primary key(id_visit_checkout),
		constraint fk_visits_checkin foreign key(id_visit_checkin) references t_visits_checkin(id_visit_checkin)
	)
go
/****** Object:  Table dbo.t_employees    Script Date: 14/10/2017 16:36:27 ******/
create table t_employees
	(
		coy_ID nvarchar(50),
		complete_name_employee nvarchar(100),
		surname nvarchar(50),
		postname nvarchar(50),
		given_name nvarchar(50),
		sex nvarchar(50),
		nationality nvarchar(50),
		place_of_birth nvarchar(50),
		date_of_birth date,
		province nvarchar(50),
		district nvarchar(50),
		territory nvarchar(50),
		sect_cheff nvarchar(50),
		village nvarchar(50),
		photo image
		constraint pk_employee primary key(coy_ID)
	)
go
/****** Object:  Table dbo.t_status_employee    Script Date: 14/10/2017 16:36:27 ******/
create table t_status_employee
	(
		id_status_employee nvarchar(50),
		title_status nvarchar(50),
		record_date date,
		constraint pk_status_employee primary key(id_status_employee)
	)
go
/****** Object:  Table dbo.t_bank    Script Date: 14/10/2017 16:36:27 ******/
create table t_bank
	(
		id_bank nvarchar(50),
		bank_name nvarchar(50),
		swift_code nvarchar(50),
		bank_code nvarchar(50),
		constraint pk_bank primary key(id_bank)
	)
go
/****** Object:  Table dbo.t_bank_details    Script Date: 14/10/2017 16:36:27 ******/
create table t_bank_details
	(
		id_bank_details int,
		coy_ID nvarchar(50),
		id_bank nvarchar(50),
		bank_account_number nvarchar(50),
		branch_code nvarchar(50),
		account_key nvarchar(50),
		record_date date,
		constraint pk_bank_details primary key(id_bank_details),
		constraint fk_bank foreign key(id_bank) references t_bank(id_bank),
		constraint kf_employee_bankdetails foreign key(coy_ID) references t_employees(coy_ID)
	)
go
/****** Object:  Table dbo.t_department    Script Date: 14/10/2017 16:36:27 ******/
create table t_department
	(
		id_department nvarchar(50),
		title nvarchar(50),
		constraint pk_department primary key(id_department)
	)
go
/****** Object:  Table dbo.t_driving_license    Script Date: 14/10/2017 16:36:27 ******/
create table t_driving_license
	(
		id_driving_license nvarchar(50),
		issued_day date,
		expiry_day date,
		coy_ID nvarchar(50),
		record_date date,
		constraint pk_driving_license primary key(id_driving_license),
		constraint fk_employee_driving foreign key(coy_ID) references t_employees(coy_ID)
	)
go
/****** Object:  Table dbo.t_job_employee    Script Date: 14/10/2017 16:36:27 ******/
create table t_job_employee
	(
		id_job_employee_title nvarchar(50),
		id_job_french nvarchar(50),
		id_department nvarchar(50),
		constraint pk_job primary key(id_job_employee_title),
		constraint fk_job_department foreign key(id_department) references t_department(id_department)
	)
go
/****** Object:  Table dbo.t_medical_info    Script Date: 14/10/2017 16:36:27 ******/
create table t_medical_info
	(
		id_medical_info int identity(1,1),
		test_day date,
		expiry_day date,		
		clinic_name nvarchar(50),
		coy_ID nvarchar(50),
		constraint pk_medical_info primary key(id_medical_info),
		constraint fk_employee_medical_info foreign key(coy_ID) references t_employees(coy_ID)
	)
go
/****** Object:  Table dbo.t_nat_ID    Script Date: 14/10/2017 16:36:27 ******/
create table t_nat_ID
	(
		natID_number nvarchar(50),
		id_place_natID nvarchar(50),
		id_date_natID date,
		coy_ID nvarchar(50),
		record_date date,
		constraint pk_natID primary key(natID_number),
		constraint fk_employee_natID foreign key(coy_ID) references t_employees(coy_ID)
	)
go
/****** Object:  Table dbo.t_passport    Script Date: 14/10/2017 16:36:27 ******/
create table t_passport
	(
		passport_number nvarchar(50),
		issued_day date,
		expiry_day date,
		place nvarchar(50),
		coy_ID nvarchar(50),
		comment nvarchar(200),
		constraint pk_passport primary key(passport_number),
		constraint fk_employee_passport foreign key(coy_ID) references t_employees(coy_ID)
	)
go
/****** Object:  Table dbo.t_type_RR    Script Date: 14/10/2017 16:36:27 ******/
create table t_type_RR
	(
		id_RR nvarchar(50),
		title_RR nvarchar(50),
		constraint pk_RR primary key(id_RR)
	)
go
/****** Object:  Table dbo.t_visa_type    Script Date: 14/10/2017 16:36:27 ******/
create table t_visa_type
	(
		visa_title nvarchar(50),
		description_visa nvarchar(200),
		constraint pk_visa_type primary key(visa_title)
	)
go
/****** Object:  Table dbo.t_visa    Script Date: 14/10/2017 16:36:27 ******/
create table t_visa
	(
		visa_ref nvarchar(50),
		date_issued date,
		expiry_day date,
		visa_title nvarchar(50),
		coy_ID nvarchar(50),
		constraint pk_visa primary key(visa_ref),
		constraint fk_employee_work_visa foreign key(coy_ID) references t_employees(coy_ID),
		constraint fk_visa_to_type foreign key(visa_title) references t_visa_type(visa_title)
	)
go
alter table t_visa
add expiry_state nvarchar(50);
select * from t_visa
/****** Object:  Table dbo.t_vsr    Script Date: 14/10/2017 16:36:27 ******/
create table t_vsr
	(
		vsr_ref nvarchar(50),
		date_issued date,
		expiry_day date,
		first_exit_date date,
		place_issued nvarchar(50),
		coy_ID nvarchar(50),
		constraint pk_vsr primary key(vsr_ref),
		constraint fk_employee_vsr foreign key(coy_ID) references t_employees(coy_ID)
	)
go
/****** Object:  Table dbo.t_resident_card    Script Date: 14/10/2017 16:36:27 ******/
create table t_resident_card
	(
		resident_card_number nvarchar(50),
		date_issued date,
		expiry_day date,
		place_issued nvarchar(50),
		coy_ID nvarchar(50),
		constraint pk_resident_card primary key(resident_card_number),
		constraint fk_employee_resid_card foreign key(coy_ID) references t_employees(coy_ID)
	)
go
create table t_contract
(
	id_contract nvarchar(50),
	descr_contrat nvarchar(100),
	constraint pk_type_contr primary key(id_contract)
)
go

/****** Object:  Table dbo.t_engagement_employee    Script Date: 14/10/2017 16:36:27 ******/
create table t_engagement_employee
	(
		id_engagement_employee int identity,
		coy_ID nvarchar(50),
		date_engagement date,
		id_status_employee nvarchar(50),
		current_adress nvarchar(50),
		marital_status nvarchar(50),
		telephone_1 nvarchar(50),
		telephone_2 nvarchar(50),
		constraint pk_engagement_employee primary key(id_engagement_employee),
		constraint fk_employee_engagement foreign key(coy_ID) references t_employees(coy_ID),
		constraint fk_status_engagement foreign key(id_status_employee) references t_status_employee(id_status_employee)
	)
go
alter table t_engagement_employee
	add id_contract nvarchar(50),
	constraint fk_type_contrat foreign key(id_contract) references t_contract(id_contract) on delete cascade on update cascade
go
alter table t_engagement_employee
add date_fin_contrat date
go
select * from t_engagement_employee
alter table t_engagement_employee
add id_type_contrat nvarchar
/****** Object:  Table dbo.t_leave_in    Script Date: 14/10/2017 16:36:27 ******/
create table t_leave_in
	(
		id_leave_in int identity(1,1),
		id_engagement_employee int,
		date_leave_in date,
		expected_date_leave_out date,
		motive nvarchar(50),
		comment_leave nvarchar(50),
		constraint pk_leave_in primary key(id_leave_in),
		constraint fk_employee_leave_in foreign key(id_engagement_employee) references t_engagement_employee(id_engagement_employee)
	)
go
/****** Object:  Table dbo.t_leave_end    Script Date: 14/10/2017 16:36:27 ******/
create table t_leave_end
	(
		id_leave_end int identity(1,1),
		id_leave_in int,
		date_leave_end date,
		days_on_leave int,
		comment_leave_end nvarchar(50),
		constraint pk_leave_end primary key(id_leave_end),
		constraint fk_leave_in_leave_end foreign key(id_leave_in) references t_leave_in(id_leave_in)
	)
go
/****** Object:  Table dbo.t_affectation_social_security_reg    Script Date: 14/10/2017 16:36:27 ******/
create table t_affectation_social_security_reg
	(
		id_affectation_ssrgn int identity(1,1),
		id_engagement_employee int,
		social_security_reg_number nvarchar(50) unique,		
		record_date date,
		constraint pk_affectation_ssrgn primary key(id_affectation_ssrgn),
		constraint fk_engag_emp_affec_ssrgn foreign key(id_engagement_employee) references t_engagement_employee(id_engagement_employee)
	)
go
/****** Object:  Table dbo.t_affectation_flight    Script Date: 14/10/2017 16:36:27 ******/
create table t_affectation_flight
	(
		id_affectation_flight int identity(1,1),
		destination_place nvarchar(50),
		id_engagement_employee int,

		constraint pk_affectation_flight primary key(id_affectation_flight),
		constraint fk_engag_emp_affec_flight foreign key(id_engagement_employee) references t_engagement_employee(id_engagement_employee)
	)
go
/****** Object:  Table dbo.t_affectation_RR    Script Date: 14/10/2017 16:36:27 ******/
create table t_affectation_RR
	(
		id_affectation_RR int identity(1,1),
		id_RR nvarchar(50),
		id_engagement_employee int,
		date_affectation date,
		price decimal,
		constraint pk_affectation_RR primary key(id_affectation_RR),
		constraint fk_RR foreign key(id_RR) references t_type_RR(id_RR),
		constraint fk_engag_emp_affec_RR foreign key(id_engagement_employee) references t_engagement_employee(id_engagement_employee)
	)
go
/****** Object:  Table dbo.t_affectation_site    Script Date: 14/10/2017 16:36:27 ******/
create table t_affectation_site
	(
		id_affectation_site int identity(1,1),
		id_site nvarchar(50),
		id_engagement_employee int,
		id_job_employee_title nvarchar(50),
		date_affectation date,
		constraint pk_affectation_site primary key(id_affectation_site),
		constraint fk_site_affect foreign key(id_site) references t_site(id_site),
		constraint fk_job_employee_title foreign key(id_job_employee_title) references t_job_employee(id_job_employee_title),
		constraint fk_engag_emp_affec_site foreign key(id_engagement_employee) references t_engagement_employee(id_engagement_employee)
	)
go
/****** Object:  Table dbo.t_offsite    Script Date: 14/10/2017 16:36:27 ******/

create table t_offsite
	(
		id_offsite int identity(1,1),
		id_affectation_site int,
		date_offsite date,
		reason_offsite nvarchar(50),
		comment_offsite nvarchar(50),
		constraint pk_offsite primary key(id_offsite),
		constraint fk_affec_site foreign key(id_affectation_site) references t_affectation_site(id_affectation_site)
		)
go
/****** Object:  Table dbo.t_affectation_supervisor    Script Date: 14/10/2017 16:36:27 ******/
create table t_affectation_supervisor
	(
		id_affectation_supervisor int identity(1,1),
		id_engagement_employee int,
		supervisor_name nvarchar(50),
		date_affectation date,
		constraint pk_affectation_supervisor primary key(id_affectation_supervisor),
		constraint fk_engag_emp_affec_sup foreign key(id_engagement_employee) references t_engagement_employee(id_engagement_employee) 
	)
go
create table t_ville
(
	id_ville nvarchar(50),
	denomination nvarchar(50),
	constraint pk_ville primary key(id_ville)
)
go
create table t_structure
(
	id_structure nvarchar(50),
	designation_structure nvarchar(50),
	id_ville nvarchar(50),
	constraint pk_structure primary key(id_structure),
	constraint fk_ville foreign key(id_ville) references t_ville(id_ville)
)																		
go
create table t_liens
(
	id_lien nvarchar(50),
	description_lien nvarchar(100),
	constraint pk_lien primary key(id_lien)
)
create table t_dependents
(
	id_dependents nvarchar(50),
	noms nvarchar(100) not null,
	date_naissance date,
	sexe nvarchar(50),
	adresse nvarchar(100),
	id_lien	nvarchar(50),
	photo image,
	coy_ID nvarchar(50),
	constraint pk_dependents primary key(id_dependents),
	constraint fk_agent foreign key(coy_ID) references t_employees(coy_ID),
	constraint fk_liens foreign key(id_lien) references t_liens(id_lien)
)
go
create table t_affectation_structure
(
	num_affectation int identity,
	coy_ID nvarchar(50),
	id_structure nvarchar(50),
	date_affectation date,
	constraint pk_affectation_structure primary key(num_affectation),
	constraint fk_coy_ID foreign key(coy_ID) references t_employees(coy_ID),
	constraint fk_structure foreign key(id_structure) references t_structure(id_structure)
)
go
create table t_login
(
	username nvarchar(50),
	pwd nvarchar(50),
	constraint pk_login primary key(username)
)
go
create procedure rechercher_login
@username nvarchar(50),
@pwd nvarchar(50)
as
	select * from t_login
		where
			username=@username and pwd=@pwd
go
create procedure enregistrer_login
@username nvarchar(50),
@pwd nvarchar(50)
as
	merge into t_login
	using (select @username as x_id) as x_source
	on(x_source.x_id=t_login.username)
	when matched then
		update
			set
				pwd=@pwd
	when not matched then
		insert
			(username,pwd)
		values
			(@username,@pwd);
go
create procedure supprimer_login
@username nvarchar(50)
as
	delete from t_login
		where username=@username
go
create procedure afficher_ville
as
	select top 20 
		id_ville as 'Ville',
		denomination as 'Description'
	from t_ville
		order by id_ville asc
go
create procedure enregistrer_ville
@id_ville nvarchar(50),
@denomination nvarchar(50)
as
	merge into t_ville
	using (select @id_ville as x_id) as x_source
	on(x_source.x_id=t_ville.id_ville)
	when matched then
	update set
		denomination=@denomination
	when not matched then
		insert
			(id_ville, denomination)
		values
			(@id_ville, @denomination);
go
create procedure supprimer_ville
@id_ville nvarchar(50)
as
	delete from t_ville
		where id_ville=@id_ville
go
create procedure recuperer_combobox_ville
as
	select 
		id_ville
	from t_ville
		order by id_ville asc
go
create procedure afficher_liens
as
	select top 20
		id_lien as 'Lien de parent�',
		description_lien as 'Description'
	from t_liens
		order by id_lien asc
go
create procedure enregistrer_lien
@id_lien nvarchar(50),
@description_lien nvarchar(100)
as
	merge into t_liens
	using(select @id_lien as x_id)as x_source
	on(x_source.x_id=t_liens.id_lien)
	when matched then
		update set
			description_lien=@description_lien
	when not matched then
		insert 
			(id_lien, description_lien)
		values
			(@id_lien, @description_lien);
go
create procedure supprimer_lien
@id_lien nvarchar(50)
as
	delete from t_liens	
		where id_lien=@id_lien
go
create procedure recuperer_combobox_lien
as
	select
		id_lien
	from t_liens
		order by id_lien asc
go
create procedure afficher_structure
as
	select top 20
		id_structure as 'Structure',
		designation_structure as 'Description',
		id_ville as 'Ville'
	from t_structure
		order by id_ville asc
go
create procedure rechercher_structure_parID
@id_structure nvarchar(50)
as
	select top 20
		id_structure as 'Structure',
		designation_structure as 'Description',
		id_ville as 'Ville'
	from t_structure
		where id_structure=@id_structure
go
create procedure rechercher_structure_parville
@id_structure nvarchar(50)
as
	select top 20
		id_structure as 'Structure',
		designation_structure as 'Description',
		id_ville as 'Ville'
	from t_structure
		where id_structure=@id_structure
go
create procedure enregistrer_structure
@id_structure nvarchar(50),
@designation_structure nvarchar(100),
@id_ville nvarchar(50)
as
	merge into t_structure
	using (select @id_structure as x_id)as x_source
	on(x_source.x_id=t_structure.id_structure)
	when matched then
		update set
			designation_structure=@designation_structure,
			id_ville=@id_ville
	when not matched then
		insert 
			(id_structure, designation_structure, id_ville)
		values
			(@id_structure, @designation_structure, @id_ville);
go
create procedure supprimer_structure
@id_structure nvarchar(50)
as
	delete from t_structure
		where id_structure=@id_structure
go
create procedure recuperer_combo_structure
@id_ville nvarchar(50)
as
	select
		id_structure
	from t_structure
	where id_ville=@id_ville
		order by id_structure asc
go

create procedure rechercher_coy_ID
@complete_name_employee nvarchar(100)
as
	select top 1
		coy_ID
	from t_employees
		where complete_name_employee=@complete_name_employee
go

create procedure afficher_dependents
as
	select top 20
		id_dependents as 'ID Dependent',
		noms as 'Noms',
		date_naissance as 'Date de naissance',
		sexe as 'Sexe',
		adresse as 'Adresse',
		id_lien as 'Lien F.',
		photo as 'Photo.',
		coy_ID as 'ID Agent'
	from t_dependents
		order by id_dependents asc
go
create procedure enregistrer_dependent
@id_dependents nvarchar(50),
@noms nvarchar(100),
@date_naissance date,
@sexe nvarchar(50),
@adresse nvarchar(100),
@id_lien nvarchar(50),
@photo image,
@coy_ID nvarchar(50)
as
	merge into t_dependents
	using (select @id_dependents as x_id)as x_source
	on(x_source.x_id=t_dependents.id_dependents)
	when matched then
		update set
			noms=@noms,
			date_naissance=@date_naissance,
			sexe=@sexe,
			adresse=@adresse,
			id_lien=@id_lien,
			photo=@photo,
			coy_ID=@coy_ID
	when not matched then
		insert
			(id_dependents, noms, date_naissance, sexe, adresse, id_lien, photo, coy_ID)
		values
			(@id_dependents, @noms, @date_naissance, @sexe, @adresse, @id_lien, @photo, @coy_ID);
go
create procedure supprimer_dependents
@id_dependents nvarchar(50)
as
	delete from t_dependents
	where 
		id_dependents=@id_dependents
go
create procedure rechercher_code_dependents
@id_dependents nvarchar(50)
as
	select top 20
		id_dependents as 'ID Dependent',
		noms as 'Noms',
		date_naissance as 'Date de naissance',
		sexe as 'Sexe',
		adresse as 'Adresse',
		id_lien as 'Lien F.',
		photo as 'Photo.',
		coy_ID as 'ID Agent'
	from t_dependents
	where id_dependents like '%'+@id_dependents+'%'
		order by id_dependents desc
go
create procedure rechercher_nom_dependents
@noms nvarchar(50)
as
	select top 20
		id_dependents as 'ID Dependent',
		noms as 'Noms',
		date_naissance as 'Date de naissance',
		sexe as 'Sexe',
		adresse as 'Adresse',
		id_lien as 'Lien F.',
		photo as 'Photo.',
		coy_ID as 'ID Agent'
	from t_dependents
	where noms like '%'+@noms+'%'
		order by id_dependents desc
go
create procedure rechercher_code_dependant
@code nvarchar(50)
as
	select top 20
		id_dependents as 'ID Dependent',
		noms as 'Noms',
		date_naissance as 'Date de naissance',
		sexe as 'Sexe',
		adresse as 'Adresse',
		id_lien as 'Lien F.',
		photo as 'Photo.',
		coy_ID as 'ID Agent'
	from t_dependents
	where id_dependents like '%'+@code+'%'
		order by id_dependents desc
go
create procedure afficher_affectation
as
	select top 20
		num_affectation as 'Num. Aff.',
		coy_ID as 'Code Agent',
		id_structure as 'Structure',
		date_affectation as 'Date Affectation'
	from t_affectation_structure
	order by num_affectation desc
go
create procedure inserer_affectation
@coy_ID nvarchar(50),
@id_structure nvarchar(50),
@date_affectation date
as
	insert into t_affectation_structure
		(coy_ID,id_structure,date_affectation)
	values
		(@coy_ID,@id_structure,@date_affectation)
go
create procedure modifier_affectation
@num_affectation int,
@coy_ID nvarchar(50),
@id_structure nvarchar(50),
@date_affectation date
as
	update t_affectation_structure
		set	
			coy_ID=@coy_ID,
			id_structure=@id_structure,
			date_affectation=@date_affectation
		where
			num_affectation=@num_affectation
go
create procedure supprimer_affectation
@num_affectation int
as
	delete from t_affectation_structure
		where num_affectation=@num_affectation
go
create procedure rechercher_affectation_paragent
@coy_ID nvarchar(50)
as
	select top 20
		num_affectation as 'Num. Aff.',
		coy_ID as 'Code Agent',
		id_structure as 'Structure',
		date_affectation as 'Date Affectation'
	from t_affectation_structure
	where
		coy_ID=@coy_ID
	order by num_affectation desc
go
create procedure rechercher_affectation_parstructure
@id_structure nvarchar(50)
as
	select top 20
		num_affectation as 'Num. Aff.',
		coy_ID as 'Code Agent',
		id_structure as 'Structure',
		date_affectation as 'Date Affectation'
	from t_affectation_structure
	where
		id_structure=@id_structure
	order by num_affectation desc
go
create procedure imprimer_liste_structure
as
	select * from t_structure
go
create procedure imprimer_liste_dependants
as
	select
		id_dependents, 
		noms, 
		date_naissance, 
		sexe, 
		adresse, 
		id_lien
	from            
		t_dependents
	order by 
		noms asc
go
create procedure charts_nombre_familles
as
	select count
		(distinct coy_ID)
	from t_dependents
go
create procedure charts_nombre_agent
as
	select count
		(coy_ID)
	from t_employees
go
create procedure charts_nombre_filles
as
	select count
		(id_dependents)
	from t_dependents
		where sexe like 'female'
go
create procedure charts_nombre_dependants
as
	select count	
		(id_dependents)
	from t_dependents
go
create procedure charts_nombre_garcons
as
	select count
		(id_dependents)
	from t_dependents
		where sexe like 'male'
go
create procedure charts_dependants_paragent
as
	select coy_ID, count(id_dependents) as nombre_dependants
	from t_dependents 
		group by coy_ID 
			order by nombre_dependants desc
go
create procedure charts_nombre_conjoint
as
	select count(id_dependents)
	from t_dependents
		where id_lien like 'Conjoint'
go
create procedure charts_nombre_enfants
as
	select count(id_dependents)
	from t_dependents
		where id_lien like 'Enfant'
go
create procedure charts_sans_dependants
as
	select count(coy_ID)
	from t_employees
		where coy_ID not in
			(select distinct coy_ID from t_dependents)
go
create procedure rechercher_employee
@input nvarchar(50)
	as
		select top 50 
			coy_ID as 'Coy ID',
			surname as 'Surname',
			postname as 'Postname',
			given_name as 'Given Name',
			sex as 'Sex',
			nationality as 'Nationality',
			place_of_birth as 'POB',
			date_of_birth as 'DOB',
			province as 'Province',
			district as 'District',
			territory as 'Territory',
			sect_cheff as 'Sect/Cheff',
			village as 'Village',
			photo as 'Photo'
		from t_employees
			where complete_name_employee like '%'+@input+'%'
go
create procedure supprimer_employee
@coy_ID nvarchar(50)
as
	delete from t_employees
		where coy_ID=@coy_ID
go
create procedure inserer_employee
	@coy_ID nvarchar(50),
	@surname nvarchar(50),
	@postname nvarchar(50),
	@given_name nvarchar(50),
	@sex nvarchar(50),
	@nationality nvarchar(50),
	@place_of_birth nvarchar(50),
	@date_of_birth date,
	@province nvarchar(50),
	@district nvarchar(50),
	@territory nvarchar(50),
	@sect_cheff nvarchar(50),
	@village nvarchar(50),
	@photo image
	as
		merge t_employees
		using (select @coy_ID as 'x_id') as x_source
		on(x_source.x_id=coy_ID)
		when matched then
			update set
				complete_name_employee=@surname+' '+@postname+' '+@given_name,
				surname=@surname,
				postname=@postname,
				given_name=@given_name,
				sex=@sex,
				nationality=@nationality,
				place_of_birth=@place_of_birth,
				date_of_birth=@date_of_birth,
				province=@province,
				district=@district,
				territory=@territory,
				sect_cheff=@sect_cheff,
				village=@village,
				photo=@photo
		when not matched then
			insert
			(coy_ID, complete_name_employee,surname,postname,given_name,sex,nationality,place_of_birth, date_of_birth, province, district, territory, sect_cheff,village,photo)
			values
			(@coy_ID, @surname+' '+@postname+' '+@given_name,@surname,@postname,@given_name,@sex,@nationality,@place_of_birth, @date_of_birth, @province, @district, @territory, @sect_cheff,@village,@photo);
go
create procedure afficher_employees
as
select top 30 
	coy_ID as 'Coy ID',
	surname as 'Surname',
	postname as 'Postname',
	given_name as 'Given Name',
	sex as 'Sex',
	nationality as 'Nationality',
	place_of_birth as 'POB',
	date_of_birth as 'DOB',
	province as 'Province',
	district as 'District',
	territory as 'Territory',
	sect_cheff as 'Sect/Cheff',
	village as 'Village',
	photo as 'Photo'
from t_employees
order by coy_ID desc
go
create procedure afficher_employees_params
@search nvarchar(50)
as
select top 50 
	coy_ID as 'Coy ID',
	surname as 'Surname',
	postname as 'Postname',
	given_name as 'Given Name',
	sex as 'Sex',
	nationality as 'Nationality',
	place_of_birth as 'POB',
	date_of_birth as 'DOB',
	province as 'Province',
	district as 'District',
	territory as 'Territory',
	sect_cheff as 'Sect/Cheff',
	village as 'Village',
	photo as 'Photo'
from t_employees
	where coy_ID like '%'+@search+'%'
order by coy_ID desc
go
create procedure rechercher_nom_employee
@complete_name nvarchar(50)
as
	select 
		top 100
			complete_name_employee
	from t_employees
		where
			complete_name_employee like '%'+@complete_name+'%'
go
create procedure rechercher_nom_employee_engage
@complete_name nvarchar(50)
as
	select top 100
		t_employees.complete_name_employee
	from            
		t_employees inner join
		t_engagement_employee on 
			t_employees.coy_ID = t_engagement_employee.coy_ID
	where
			t_employees.complete_name_employee like '%'+@complete_name+'%'
go
create procedure remplir_lisbox_nom
as
	select 
		top 100
			complete_name_employee
	from t_employees
	order by complete_name_employee asc
go
create procedure remplir_listbox_engaged
as
	select top 100
		t_employees.complete_name_employee
from            
	t_employees inner join
    t_engagement_employee on 
		t_employees.coy_ID = t_engagement_employee.coy_ID
go
create procedure rechercher_engagement_ID
@coy_ID nvarchar(50)
as
	select top 1
		id_engagement_employee
	from t_engagement_employee
		where coy_ID=@coy_ID
	order by date_engagement desc
go
create procedure rechercher_engagement_parAgent
@coy_ID nvarchar(50)
as
	select
		id_engagement_employee as 'ID Num.',
		coy_ID as 'Coy ID',
		date_engagement as 'Date',
		id_status_employee as 'Status Emp.',
		current_adress as 'Address',
		marital_status as 'M. Status',
		telephone_1 as 'Phone 1',
		telephone_2 as 'Phone 2'
	from t_engagement_employee
		where coy_ID=@coy_ID
	order by date_engagement desc
go
create procedure afficher_engagement_employee
as
	select top 100 
		id_engagement_employee as 'ID Num.',
		coy_ID as 'Coy ID',
		date_engagement as 'Debut Contrat',
		date_fin_contrat as 'Fin Contrat',
		id_status_employee as 'Status Emp.',
		id_contract as 'Contrat',
		current_adress as 'Address',
		marital_status as 'M. Status',
		telephone_1 as 'Phone 1',
		telephone_2 as 'Phone 2'
	from t_engagement_employee
	order by 
		id_engagement_employee desc
go
create procedure recuperer_status_employee
as
	select 
		id_status_employee
	from t_status_employee
		order by
			title_status asc
go
create procedure enregistrer_status_employee
@id_status nvarchar(50),
@title_status nvarchar(50),
@record_date date
as
	merge into t_status_employee
		using (select @id_status as x_id) as x_source
		on(x_source.x_id=t_status_employee.id_status_employee)
		when matched then
			update set
				title_status=@title_status,
				record_date=@record_date
		when not matched then
			insert 
				(
					id_status_employee,
					title_status,
					record_date
				)
			values
				(
					@id_status,
					@title_status,
					@record_date
				);
go
create procedure supprimer_status_employee
@id_status nvarchar(50)
as
	delete from t_status_employee
		where
			id_status_employee=@id_status
go
create procedure enregistrer_engagement_employee
@coy_ID nvarchar(50),
@date_engagement date,
@date_fin_contrat date,
@id_contract nvarchar(50),
@id_status_employee nvarchar(50),
@current_adress nvarchar(50),
@marital_status nvarchar(50),
@telephone_1 nvarchar(50),
@telephone_2 nvarchar(50)
as
	insert into t_engagement_employee
		(coy_ID,date_engagement,id_status_employee,current_adress,marital_status,telephone_1,telephone_2,date_fin_contrat,id_contract)
	values
		(@coy_ID,@date_engagement,@id_status_employee,@current_adress,@marital_status,@telephone_1,@telephone_2,@date_fin_contrat,@id_contract)
go
alter procedure modifier_engagement_employee
@id_engagement_employee int,
@coy_ID nvarchar(50),
@date_engagement date,
@date_fin_contrat date,
@id_contract nvarchar(50),
@id_status_employee nvarchar(50),
@current_adress nvarchar(50),
@marital_status nvarchar(50),
@telephone_1 nvarchar(50),
@telephone_2 nvarchar(50)
as
	update t_engagement_employee
		set
			coy_ID=@coy_ID,
			date_engagement=@date_engagement,
			id_status_employee=@id_status_employee,
			current_adress=@current_adress,
			marital_status=@marital_status,
			telephone_1=@telephone_1,
			telephone_2=@telephone_2,
			date_fin_contrat=@date_fin_contrat,
			id_contract=@id_contract
		where
			id_engagement_employee=@id_engagement_employee
go
create proc supprimer_engagement_employee
@id_engagement_employee int
as
	delete from t_engagement_employee
		where
			id_engagement_employee=@id_engagement_employee
go
create procedure afficher_leave_in
as
select top 50
	id_leave_in as 'ID',
	id_engagement_employee as 'Id. Eng.',
	date_leave_in as 'Date Leave in',
	expected_date_leave_out as 'Date Leave out',
	motive as 'Motive',
	comment_leave as 'Comments'
from t_leave_in
	order by id_leave_in desc
go
create procedure enregistrer_leave_in
@id_engagement_employee int,
@date_leave_in date,
@expected_date_leave_out date,
@motive nvarchar(50),
@comment_leave nvarchar(50)
as
	insert into t_leave_in
		(id_engagement_employee, date_leave_in,	expected_date_leave_out, motive, comment_leave)
	values
		(@id_engagement_employee, @date_leave_in,	@expected_date_leave_out, @motive, @comment_leave)
go
create procedure modifier_leave_in
@id_leave_in int,
@id_engagement_employee int,
@date_leave_in date,
@expected_date_leave_out date,
@motive nvarchar(50),
@comment_leave nvarchar(50)
as
	update t_leave_in
		set
			id_engagement_employee=@id_engagement_employee, 
			date_leave_in=@date_leave_in,	
			expected_date_leave_out=@expected_date_leave_out, 
			motive=@motive, 
			comment_leave=@comment_leave
		where
			id_leave_in=@id_leave_in
go
create procedure supprimer_leave_in
@id_leave_in int
as
	delete from t_leave_in
		where id_leave_in=@id_leave_in
go
create procedure afficher_leave_end
as
select top 50
	id_leave_end as 'ID',
	id_leave_in as 'Leave In.',
	date_leave_end as 'Date Leave End',
	days_on_leave as 'Days on Leave',
	comment_leave_end as 'Comments'
from t_leave_end
	order by id_leave_end desc
go
create procedure enregistrer_leave_end
@id_leave_in int,
@date_leave_end date,
@days_on_leave int,
@comment_leave_end nvarchar(50)
as
	insert into t_leave_end
		(id_leave_in, date_leave_end, days_on_leave, comment_leave_end)
	values
		(@id_leave_in, @date_leave_end, @days_on_leave, @comment_leave_end)
go
create procedure modifier_leave_end
@id_leave_end int,
@id_leave_in int,
@date_leave_end date,
@days_on_leave int,
@comment_leave_end nvarchar(50)
as
	update t_leave_end
		set				
			id_leave_in =@id_leave_in,
			date_leave_end =@date_leave_end,
			days_on_leave =@days_on_leave,
			comment_leave_end =@comment_leave_end
		where
			id_leave_end =@id_leave_end
go
create procedure supprimer_leave_end
@id_leave_end int
as
	delete from t_leave_end
		where 
			id_leave_end =@id_leave_end
go
create procedure retro_leave_in
as
	select top 50
		id_leave_in as 'ID',
		id_engagement_employee as 'Id. Eng.',
		date_leave_in as 'Date Leave in',
		expected_date_leave_out as 'Date Leave out'
	from t_leave_in
		order by id_leave_in desc
go
create procedure retro_leave_in_params
@id_engagement_employee int
as
	select top 50
		id_leave_in as 'ID',
		id_engagement_employee as 'Id. Eng.',
		date_leave_in as 'Date Leave in',
		expected_date_leave_out as 'Date Leave out'
	from t_leave_in
	where
		id_engagement_employee=@id_engagement_employee
	order by id_leave_in desc
go
create procedure afficher_status_employee
as
	select top 50
		id_status_employee as 'ID',
		title_status as 'Title',
		record_date as 'Record Date' 
	from t_status_employee
		order by title_status asc
go
create procedure afficher_site
as
	select top 50 
		id_site as 'ID',
		designation_site as 'Description',
		record_date as 'Record Date'
	from t_site
		order by id_site asc
go
create procedure rechercher_site
@search nvarchar(50)
as
	select
		id_site as 'ID',
		designation_site as 'Description',
		record_date as 'Record Date'
	from t_site 
		where 
			designation_site like '%'+@search+'%'
		order by designation_site asc
go
create procedure recuperer_site
as
	 select
		id_site
	from t_site 
		order by designation_site asc
go
create procedure inserer_site
@id_site nvarchar(50),
@designation_site nvarchar(50),
@record_date date
as
	merge into t_site
	using (select @id_site as x_id) as x_source
	on(x_source.x_id=t_site.id_site)
	when matched then
		update set
			designation_site=@designation_site,
			record_date=@record_date
	when not matched then
		insert
			(id_site, designation_site, record_date)
		values
			(@id_site, @designation_site, @record_date);
go
create procedure supprimer_site
@id_site nvarchar(50)
as
	delete from t_site
		where 
			id_site=@id_site
go
 create procedure afficher_bank
 as
	select top 50
		id_bank as 'ID',
		bank_name as 'Bank Name',
		swift_code as 'Swift',
		bank_code as 'Bank Code'
	from t_bank
		order by id_bank asc
go
create procedure recuperer_bank
as
	select
		id_bank		
	from t_bank
		order by id_bank asc
go
create procedure enregistrer_bank
@id_bank nvarchar(50),
@bank_name nvarchar(50),
@swift_code nvarchar(50),
@bank_code nvarchar(50)
as
	merge into t_bank
	using(select @id_bank as x_id)as x_source
	on(x_source.x_id=t_bank.id_bank)
	when matched then
		update set
			bank_name=@bank_name,
			swift_code=@swift_code,
			bank_code=@bank_code
	when not matched then
		insert
			(id_bank, bank_name, swift_code, bank_code)
		values
			(@id_bank, @bank_name, @swift_code, @bank_code);
go
create procedure supprimer_bank
@id_bank nvarchar(50)
as
	delete from t_bank
		where
			id_bank=@id_bank
go
create procedure rechercher_bank
@search nvarchar(50)
as
	select top 50
		id_bank as 'ID',
		bank_name as 'Bank Name',
		swift_code as 'Swift',
		bank_code as 'Bank Code'
	from t_bank			
		where 
			bank_name like '%'+@search+'%'
		order by id_bank asc
go
 create procedure afficher_department
 as
	select top 50
		 id_department as 'ID',
		 title as 'Description'
	from t_department
		order by id_department asc
go
create procedure rechercher_departement
@search_name nvarchar(50)
as
	 select top 50
		 id_department as 'ID',
		 title as 'Description'
	from t_department
		where
			title like '%'+@search_name+'%'
	order by id_department asc
go
create procedure recuperer_department
as
	select 
		id_department
	from t_department
		order by id_department
go
create procedure enregistrer_department
@id_department nvarchar(50),
@title nvarchar(50)
as
	merge into t_department
	using (select @id_department as x_id)as x_source
	on (x_source.x_id=t_department.id_department)
	when matched then
		update set
			title=@title
	when not matched then
		insert
		(id_department, title)
		values
		(@id_department, @title);
go
create procedure supprimer_department
@id_department nvarchar(50)
as
	delete from t_department
		where id_department=@id_department
go
--------------------------Today's Code---------------------------
create procedure afficher_visa_type
as
	select top 50
		visa_title as 'V. Title',
		description_visa as 'Description'
	from t_visa_type
		order by visa_title asc
go
create procedure recuperer_visa_type
as
	 select
		visa_title
	from t_visa_type
		order by visa_title asc
go
create procedure rechercher_visa_type
@search_name nvarchar(50)
as
	select top 50
		visa_title as 'V. Title',
		description_visa as 'Description'
	from t_visa_type
		order by visa_title asc
go
create procedure enregistrer_visa_type
@visa_title nvarchar(50),
@description_visa nvarchar(200)
as
	merge into t_visa_type
	using(select @visa_title as x_id)as x_source
	on(x_source.x_id=t_visa_type.visa_title)
	when matched then
		update set
			description_visa=@description_visa
	when not matched then
		insert
			(visa_title, description_visa)
		values
			(@visa_title, @description_visa);
go
create procedure supprimer_visa_type
@visa_title nvarchar(50)
as	
	delete from t_visa_type
		where visa_title=@visa_title
go
--------------------------Today's Code---------------------------
create procedure afficher_RR_type
as
	select top 50
		id_RR as 'RR. ID',
		title_RR as 'Description'
	from t_type_RR
		order by id_RR asc
go
create procedure recuperer_RR_type
as
	 select
		id_RR
	from t_type_RR
		order by id_RR asc
go
create procedure rechercher_RR_type
@search_name nvarchar(50)
as
	select top 50
		id_RR as 'RR. ID',
		title_RR as 'Description'
	from t_type_RR
	where title_RR like '%'+@search_name+'%'
		order by id_RR asc
go
create procedure enregistrer_RR_type
@id_RR nvarchar(50),
@title_RR nvarchar(50)
as
	merge into t_type_RR
	using(select @id_RR as x_id)as x_source
	on(x_source.x_id=t_type_RR.id_RR)
	when matched then
		update set
			title_RR=@title_RR
	when not matched then
		insert
			(id_RR, title_RR)
		values
			(@id_RR, @title_RR);
go
create procedure supprimer_RR_type
@id_RR nvarchar(50)
as	
	delete from t_type_RR
		where id_RR=@id_RR
go
--------------------------Today's Code---------------------------
create procedure afficher_job
as
	select top 50
		id_job_employee_title as 'Job ID',
		id_job_french as 'French',
		id_department as 'Department'
	from t_job_employee
		order by id_job_employee_title asc
go
create procedure recuperer_job
as
	 select
		id_job_employee_title
	from t_job_employee
		order by id_job_employee_title asc
go
create procedure rechercher_job
@search_name nvarchar(50)
as
	select top 50
		id_job_employee_title as 'Job ID',
		id_job_french as 'French',
		id_department as 'Department'
	from t_job_employee
	where id_job_employee_title like '%'+@search_name+'%'
		order by id_job_employee_title asc
go
create procedure enregistrer_job
@id_job_employee_title nvarchar(50),
@id_job_french nvarchar(50),
@id_department nvarchar(50)
as
	merge into t_job_employee
	using(select @id_job_employee_title as x_id)as x_source
	on(x_source.x_id=t_job_employee.id_job_employee_title)
	when matched then
		update set
			id_job_french=@id_job_french,
			id_department=@id_department
	when not matched then
		insert
			(id_job_employee_title, id_job_french, id_department)
		values
			(@id_job_employee_title, @id_job_french, @id_department);
go
create procedure supprimer_job
@id_job_employee_title nvarchar(50)
as	
	delete from t_job_employee
		where id_job_employee_title=@id_job_employee_title
go
--------------------------Today's Code---------------------------
create procedure afficher_nat_ID
as
	select top 50
		natID_number as 'NatID. Number',
		id_place_natID as 'Issued Place',
		id_date_natID as 'Issued Date',
		coy_ID as 'Coy. ID',
		record_date as 'Record Date'
	from t_nat_ID
		order by record_date desc, natID_number asc
go
create procedure rechercher_nat_ID
@search_name nvarchar(50)
as
	select top 50
		natID_number as 'NatID. Number',
		id_place_natID as 'Issued Place',
		id_date_natID as 'Issued Date',
		coy_ID as 'Coy. ID',
		record_date as 'Record Date'
	from t_nat_ID
	where coy_ID like '%'+@search_name+'%'
		order by record_date desc, natID_number asc
go
create procedure enregistrer_nat_ID
@natID_number nvarchar(50),
@id_place_natID nvarchar(50),
@id_date_natID date,
@coy_ID nvarchar(50),
@record_date date
as
	merge into t_nat_ID
	using(select @natID_number as x_id)as x_source
	on(x_source.x_id=t_nat_ID.natID_number)
	when matched then
		update set
			id_place_natID=@id_place_natID,
			id_date_natID=@id_date_natID,
			coy_ID=@coy_ID ,
			record_date=@record_date
	when not matched then
		insert
			(natID_number,id_place_natID, id_date_natID, coy_ID, record_date)
		values
			(@natID_number, @id_place_natID, @id_date_natID, @coy_ID, @record_date);
go
create procedure supprimer_nat_ID
@natID_number nvarchar(50)
as	
	delete from t_nat_ID
		where natID_number=@natID_number
go
--------------------------Today's Code---------------------------
create procedure afficher_passport
as
	select top 50
		passport_number as 'PP. Number',
		issued_day as 'Issued Date',
		expiry_day as 'Expiry Date',
		place as 'Place',
		coy_ID as 'Coy. ID',
		comment as 'Comments'
	from t_passport
		order by passport_number asc
go
create procedure rechercher_passport
@search_name nvarchar(50)
as
	select top 50
		passport_number as 'PP. Number',
		issued_day as 'Issued Date',
		expiry_day as 'Expiry Date',
		place as 'Place',
		coy_ID as 'Coy. ID',
		comment as 'Comments'
	from t_passport
	where coy_ID like '%'+@search_name+'%'
		order by expiry_day desc
go
create procedure enregistrer_passport
@passport_number nvarchar(50),
@issued_day date,
@expiry_day date,
@place nvarchar(50),
@coy_ID nvarchar(50),
@comment nvarchar(200)
as
	merge into t_passport
	using(select @passport_number as x_id)as x_source
	on(x_source.x_id=t_passport.passport_number)
	when matched then
		update set
			issued_day=@issued_day,
			expiry_day=@expiry_day,
			place=@place,
			coy_ID=@coy_ID,
			comment=@comment
	when not matched then
		insert
			(passport_number,issued_day, expiry_day, place, coy_ID, comment)
		values
			(@passport_number,@issued_day, @expiry_day, @place, @coy_ID, @comment);
go
create procedure supprimer_passport
@passport_number nvarchar(50)
as	
	delete from t_passport
		where passport_number=@passport_number
go
create procedure rechercher_expiry_passport
@date1 date,
@date2 date
as
	select        
		t_employees.coy_ID, 
		t_employees.complete_name_employee, 
		t_employees.sex, 
		t_employees.nationality, 
		t_passport.passport_number, 
		t_passport.issued_day, 
		t_passport.expiry_day, 
        t_passport.place, 
		t_passport.comment
	from            
		t_employees inner join
        t_passport on 
			t_employees.coy_ID = t_passport.coy_ID
		where 
			t_passport.expiry_day between @date1 and @date2
go
create procedure afficher_affectation_site
as
	select top 50
		id_affectation_site as 'Num.',
		id_site as 'Site',
		id_engagement_employee as 'Engagement ID',
		id_job_employee_title as 'Job Title',
		date_affectation as 'Date'
	from t_affectation_site
	order by
		date_affectation desc
go
create procedure rechercher_affectation_site
@id_engagement_employee int
as
	select top 50
		id_affectation_site as 'Num.',
		id_site as 'Site',
		id_engagement_employee as 'Engagement ID',
		id_job_employee_title as 'Job Title',
		date_affectation as 'Date'
	from t_affectation_site
		where id_engagement_employee=@id_engagement_employee
	order by
		date_affectation desc
go
create procedure enregistrer_affectation_site
@id_site nvarchar(50),
@id_engagement_employee int,
@id_job_employee_title nvarchar(50),
@date_affectation date
as
	insert into t_affectation_site
		(id_site, id_engagement_employee, id_job_employee_title, date_affectation)
	values
		(@id_site, @id_engagement_employee, @id_job_employee_title, @date_affectation)
go
create procedure modifier_affectation_site
@id_affectation_site int,
@id_site nvarchar(50),
@id_engagement_employee int,
@id_job_employee_title nvarchar(50),
@date_affectation date
as
	update t_affectation_site
		set
			id_site=@id_site,
			id_engagement_employee=@id_engagement_employee,
			id_job_employee_title=@id_job_employee_title,
			date_affectation=@date_affectation
		where
			id_affectation_site=@id_affectation_site
go
create procedure supprimer_affectation_site
@id_affectation_site int
as
	delete 
		from t_affectation_site
	where 
		id_affectation_site=@id_affectation_site
go
-------------------------------------Visa Procedures------------------------------------------------------------------
create procedure afficher_visa
as
	select top 50
		visa_ref as 'Visa Ref.',
		date_issued as 'Issued Date',
		expiry_day as 'Expiry Date',
		visa_title as 'Visa Type',
		coy_ID as 'Coy ID'
	from t_visa
		order by 
			expiry_day desc
go
create procedure enregistrer_visa
@visa_ref nvarchar(50),
@date_issued date,
@expiry_day date,
@visa_title nvarchar(50),
@coy_ID nvarchar(50)
as
	merge into t_visa
		using (select @visa_ref as x_visa_ref) as x_source
		on(x_source.x_visa_ref=t_visa.visa_ref)
		 when matched then
			update set
				date_issued=@date_issued,
				expiry_day=@expiry_day,
				visa_title=@visa_title,
				coy_id=@coy_ID
		when not matched then
			insert 
				(visa_ref, date_issued, expiry_day, visa_title, coy_ID)
			values
				(@visa_ref, @date_issued, @expiry_day, @visa_title, @coy_ID);
go
create procedure supprimer_visa
@visa_ref nvarchar(50)
as
	delete from  t_visa
		where 
			visa_ref=@visa_ref
go
create procedure rechercher_visa
@coy_ID nvarchar(50)
as
	select top 50
		visa_ref as 'Visa Ref.',
		date_issued as 'Issued Date',
		expiry_day as 'Expiry Date',
		visa_title as 'Visa Type',
		coy_ID as 'Coy ID'
	from t_visa
		where
			coy_ID=@coy_ID
		order by 
			expiry_day desc
go
create procedure afficher_driving_license
as
	select top 50
		id_driving_license as 'Dr.Liv. Number',
		issued_day as 'Issued Day',
		expiry_day as 'Expiry Day',
		coy_ID as 'Coy ID',
		record_date as 'Record Date'
	from t_driving_license
		order by record_date desc, coy_ID desc
go
create procedure enregistrer_driving_license
@id_driving_license nvarchar(50),
@issued_day date,
@expiry_day date,
@coy_ID nvarchar(50),
@record_date date
as
	merge into t_driving_license
	using(select @id_driving_license as x_id)as x_source
	on(x_source.x_id=t_driving_license.id_driving_license)
	when matched then
		update set
			id_driving_license=@id_driving_license,
			issued_day=@issued_day,
			expiry_day=@expiry_day,
			coy_ID=@coy_ID,
			record_date=@record_date
	when not matched then
		insert
			(id_driving_license,issued_day,expiry_day,coy_ID,record_date)
		values
			(@id_driving_license,@issued_day,@expiry_day,@coy_ID,@record_date);
go
create procedure supprimer_driving_license
@id_driving_license nvarchar(50)
as
	delete from t_driving_license
		where
			id_driving_license=@id_driving_license
go
create procedure expirer_visa
@visa_ref nvarchar(50)
as
	update t_visa
	set
		expiry_state='Yes'
	where
		visa_ref like @visa_ref
go
create procedure rechercher_driving
@coy_ID nvarchar(50)
as
	 select top 50
		id_driving_license as 'Dr.Liv. Number',
		issued_day as 'Issued Day',
		expiry_day as 'Expiry Day',
		coy_ID as 'Coy ID',
		record_date as 'Record Date'
	from t_driving_license
	where 
		coy_ID=@coy_ID
	order by record_date desc
go
create procedure recuperer_alerte_visa
@nombre int
as
	select        
	t_employees.coy_ID, 
	t_employees.complete_name_employee, 
	t_employees.nationality,
	t_engagement_employee.id_engagement_employee, 
	t_engagement_employee.id_status_employee, 
    t_affectation_site.id_site,
	t_visa.date_issued, 
	t_visa.expiry_day, 
	t_visa.visa_title, 
	datediff(day, getDate(), t_visa.expiry_day)as 'jours restants' 
from            
	t_affectation_site 
inner join
    t_engagement_employee on 
	t_affectation_site.id_engagement_employee = dbo.t_engagement_employee.id_engagement_employee 
inner join
    t_employees on 
	t_engagement_employee.coy_ID = dbo.t_employees.coy_ID
inner join
    t_visa on
	t_employees.coy_ID = dbo.t_visa.coy_ID
where 
	[jours restants] <= @nombre
order by 
	[jours restants] asc
go

create procedure recuperer_contrat
as
	select id_contract from t_contract
	order by id_contract asc
go
insert into t_contract
	(id_contract, descr_contrat)
values
	('CDI','Contrat a duree indeterminee'),
	('CDD','Contrat a duree determinee'),
	('CS','Contrat de stage'),
	('CJ','Contrat journalier');