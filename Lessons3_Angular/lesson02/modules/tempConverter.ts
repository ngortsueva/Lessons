export class TempConverter {
	static convertFtoC(temp: number) : string {
		return ((parseFloat(temp.toPrecision(2)) - 32) / 1.8).toFixed(1);
	}
}