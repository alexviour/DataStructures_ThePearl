using System;
using System.Drawing;
using System.Windows.Forms;

public class SeatNode
{
    public int SeatNumber { get; private set; } // Unique identifier for the seat
    public Button SeatButton { get; private set; } // Button representing the seat
    public bool IsReserved { get; private set; } // Reservation status

    // Constructor to initialize the seat
    public SeatNode(int seatNumber, Button seatButton)
    {
        if (seatButton == null)
            throw new ArgumentNullException(nameof(seatButton), "SeatButton cannot be null");

        SeatNumber = seatNumber;
        SeatButton = seatButton;
        IsReserved = false;

        // Set default appearance for unreserved seats
        ConfigureButton();
    }

    // Method to configure the button's appearance and event handlers
    private void ConfigureButton()
    {
        SeatButton.BackColor = Color.LightGray; // Default color for unreserved seats
        SeatButton.Text = $"Seat {SeatNumber}"; // Display seat number on the button
        SeatButton.Click += SeatButton_Click; // Attach click event
    }

    // Click event handler for the seat button
    private void SeatButton_Click(object sender, EventArgs e)
    {
        ToggleReservation();
    }

    // Method to toggle reservation status
    public void ToggleReservation()
    {
        if (!IsReserved)
        {
            ReserveSeat();
        }
        else
        {
            UnreserveSeat();
        }
    }

    // Method to reserve the seat
    private void ReserveSeat()
    {
        IsReserved = true;
        SeatButton.BackColor = Color.Pink; // Change color when reserved
        MessageBox.Show($"Seat {SeatNumber} has been reserved!", "Reservation Successful");
    }

    // Method to unreserve the seat
    private void UnreserveSeat()
    {
        IsReserved = false;
        SeatButton.BackColor = Color.LightGray; // Revert to default color
        MessageBox.Show($"Seat {SeatNumber} reservation has been canceled.", "Reservation Canceled");
    }
}
