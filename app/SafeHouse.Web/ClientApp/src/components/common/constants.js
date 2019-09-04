export const Constants = {
	loginMessage: 'Unesite podatke kako biste se ulogovali',
	loginTitle: 'Neque porro quisquam est qui dolorem ipsum quia dolor sit amet',
	loginDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi elit lectus, auctor eget velit quis, finibus consequat neque. Cras tempor dolor ut massa efficitur, eget luctus nisl scelerisque. Maecenas elementum varius felis vitae tincidunt',
	loginUsername: 'Korisničko ime',
	loginPassword: 'Lozinka',
	loginButton: 'Prijavi se',
	links: [
		{
			name: 'Početna',
			path: '',
			icon: 'home'
		},
		{
			name: 'Korisnici',
			path: 'users',
			icon: 'list_alt'
		},
		{
			name: 'Kreiraj novi karton',
			path: 'add',
			icon: 'create'
		},
		{
			name: 'Evidencija pruženih usluga',
			path: 'records',
			icon: 'format_list_numbered'
		},
		{
			name: 'Izvestaji',
			path: 'reports',
			icon: 'check_box'
		},
	],
	cartons: [
		{
			id: '1',
			name: 'Ivan',
			lastname: 'Ivanovic',
			visits: '5'
		},
		{
			id: '2',
			name: 'Ivan',
			lastname: 'Ivanovic',
			visits: '10'
		},
		{
			id: '3',
			name: 'Nikola',
			lastname: 'Ilic',
			visits: '3'
		},
		{
			id: '4',
			name: 'Ivan',
			lastname: 'Vasic',
			visits: '7'
		},
		{
			id: '5',
			name: 'Bojan',
			lastname: 'Pavlovic',
			visits: '9'
		},
		{
			id: '6',
			name: 'Ana',
			lastname: 'Ancic',
			visits: '15'
		},
	],
	genderOptions: [
		{
			name: "Muski",
			value: 0
		},
		{
			name: "Zenski",
			value: 1
		}
	],
	livingSpace: [
		{
			name: "Porodici",
			value: 0
		},
		{
			name: "Ustanovi",
			value: 1
		},
		{
			name: "Vrsnjackoj grupi",
			value: 2
		},
		{
			name: "Drugo",
			value: 3
		},
	],
	reports : {
		users: '5',
		visits: '15',
		meals: '15',
		hygiene: '5',
		clothes: '7',
		intervention: '2',
		education: '3',
		school: '1',
		parents: '0',
		medicalhelp: '1'
	}
};
export const web_api_url = "http://localhost:51025/api";

export default Constants;