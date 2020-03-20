/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view.backing;

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import org.primefaces.model.chart.Axis;
import org.primefaces.model.chart.AxisType;
import org.primefaces.model.chart.CategoryAxis;
import org.primefaces.model.chart.LineChartModel;
import org.primefaces.model.chart.LineChartSeries;

/**
 *
 * @author Damian
 */
@Named(value = "chartBean")
@RequestScoped
public class ChartBean {

    private LineChartModel sinecosine;

    /**
     * Creates a new instance of ChartBean
     */
    public ChartBean() {
        createLineModel();
    }

    private void createLineModel() {
        sinecosine = initSinecosine();
        sinecosine.setTitle("Sine & Cosine");
        sinecosine.setLegendPosition("i");
        sinecosine.getAxes().put(AxisType.X, new CategoryAxis("Degree"));
        sinecosine.setZoom(true);
        Axis yAxis = sinecosine.getAxis(AxisType.Y);
        yAxis.setLabel("Value");
        
    }

    private LineChartModel initSinecosine() {
        LineChartModel model = new LineChartModel();

        LineChartSeries sine = new LineChartSeries();
        sine.setLabel("Sine");
        for (int i = 0; i <= 360; i += 10) {
            sine.set(i, Math.sin(Math.toRadians(i)));
        }
        
        LineChartSeries cosine = new LineChartSeries();
        cosine.setLabel("Cosine");

        for (int i = 0; i <= 360; i += 10) {
            cosine.set(i, Math.cos(Math.toRadians(i)));
        }
        model.addSeries(sine);
        model.addSeries(cosine);

        return model;
    }

    /**
     * @return the sinecosine
     */
    public LineChartModel getSinecosine() {
        return sinecosine;
    }

    /**
     * @param sinecosine the sinecosine to set
     */
    public void setSinecosine(LineChartModel sinecosine) {
        this.sinecosine = sinecosine;
    }

}
